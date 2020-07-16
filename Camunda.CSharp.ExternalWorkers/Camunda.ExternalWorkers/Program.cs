using System;
using System.Collections.Generic;
using System.Threading;
using Camunda.Client.Model;
using Camunda.Client.Api;
using Camunda.Client.Client;
using System.Threading.Tasks;

namespace Camunda.ExternalWorkers
{
    class Program
    {
        private static string logo =
                "   ____                                _         ____  ____  __  __ \n" +
                "  / ___|__ _ _ __ ___  _   _ _ __   __| | __ _  | __ )|  _ \\|  \\/  |\n" +
                " | |   / _` | '_ ` _ \\| | | | '_ \\ / _` |/ _` | |  _ \\| |_) | |\\/| |\n" +
                " | |__| (_| | | | | | | |_| | | | | (_| | (_| | | |_) |  __/| |  | |\n" +
                "  \\____\\__,_|_| |_| |_|\\__,_|_| |_|\\__,_|\\__,_| |____/|_|   |_|  |_|\n";

        private static int pollingIntervalInMilliseconds = 5;
        private static int pollingNumberOfTasks = 100;
        private static int pollingLockTimeInMs = 5 * 60 * 1000;
        private static int pollingMaxDegreeOfParallelism = 1;
        private static Timer pollingTimer;

        private static string workerId = Guid.NewGuid().ToString();
        private static IDictionary<string, Action<LockedExternalTaskDto>> workers = new Dictionary<string, Action<LockedExternalTaskDto>>();
        private static ExternalTaskApi externalTaskApi = new ExternalTaskApi();

        static void Main(string[] args)
        {
            Console.WriteLine(logo + "\n\n" + "Deploying models and start workers.\n\nPRESS ANY KEY TO STOP WORKERS.\n\n");
            var processDefinitionApi = new ProcessDefinitionApi();
            var processDef = processDefinitionApi.GetProcessDefinitionByKey("process-manager-process");

            // new System.Uri("http://localhost:8080/engine-rest/engine/default/"), null, null);

            RegisterWorker();

            // start some instances
            var processDefApi = new ProcessDefinitionApi();
            for (int i = 0; i < 1; i++)
            {
                var processInstance = processDefApi.StartProcessInstanceByKey("process-manager-process", new StartProcessInstanceDto("Demo"));
                Console.WriteLine("Started trip booking saga " + processInstance.Links);
            }

            Console.ReadLine(); // wait for ANY KEYs
        }

        private static void RegisterWorker()
        {
            registerWorker("book-car", externalTask => {
                Console.WriteLine("Book car now...");
                externalTaskApi.CompleteExternalTaskResource(externalTask.Id);
                //camunda.ExternalTaskService.Failure(workerId, externalTask.Id, "could not connect", (externalTask.Retries ?? 3) - 1, 5000);
            });
            registerWorker("book-flight", externalTask => {
                Console.WriteLine("Reserving flight now...");
                //camunda.ExternalTaskService.Complete(workerId, externalTask.Id);
                //Console.WriteLine("Oh no - we hit a glitch!");
                //camunda.ExternalTaskService.Error(workerId, externalTask.Id, "BookingFailed");
            });

            StartPolling();
        }

        private static void StartPolling()
        {
            pollingTimer = new Timer(_ => PollTasks(), null, pollingIntervalInMilliseconds, Timeout.Infinite);
        }

        private static void PollTasks()
        {
            var tasks = externalTaskApi.FetchAndLock(new FetchExternalTasksDto(workerId, pollingNumberOfTasks) {
                Topics = new List<FetchExternalTaskTopicDto>
                {
                    new FetchExternalTaskTopicDto("book-car", pollingLockTimeInMs)
                }
            });
            Parallel.ForEach(
                tasks,
                new ParallelOptions { MaxDegreeOfParallelism = pollingMaxDegreeOfParallelism },
                (externalTask) => {
                    workers[externalTask.TopicName](externalTask);
                });

            // schedule next run
            pollingTimer.Change(pollingIntervalInMilliseconds, Timeout.Infinite);
        }

        private static void registerWorker(string topicName, Action<LockedExternalTaskDto> workerFunction)
        {
            workers.Add(topicName, workerFunction);
        }
    }
}
