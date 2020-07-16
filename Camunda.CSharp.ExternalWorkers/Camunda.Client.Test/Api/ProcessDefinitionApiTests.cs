/* 
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * OpenAPI spec version: 7.13.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Camunda.Client.Client;
using Camunda.Client.Api;
using Camunda.Client.Model;

namespace Camunda.Client.Test
{
    /// <summary>
    ///  Class for testing ProcessDefinitionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProcessDefinitionApiTests
    {
        private ProcessDefinitionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProcessDefinitionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProcessDefinitionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProcessDefinitionApi
            //Assert.IsInstanceOfType(typeof(ProcessDefinitionApi), instance, "instance is a ProcessDefinitionApi");
        }

        /// <summary>
        /// Test DeleteProcessDefinition
        /// </summary>
        [Test]
        public void DeleteProcessDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? cascade = null;
            //bool? skipCustomListeners = null;
            //bool? skipIoMappings = null;
            //instance.DeleteProcessDefinition(id, cascade, skipCustomListeners, skipIoMappings);
            
        }
        /// <summary>
        /// Test DeleteProcessDefinitionsByKey
        /// </summary>
        [Test]
        public void DeleteProcessDefinitionsByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //bool? cascade = null;
            //bool? skipCustomListeners = null;
            //bool? skipIoMappings = null;
            //instance.DeleteProcessDefinitionsByKey(key, cascade, skipCustomListeners, skipIoMappings);
            
        }
        /// <summary>
        /// Test DeleteProcessDefinitionsByKeyAndTenantId
        /// </summary>
        [Test]
        public void DeleteProcessDefinitionsByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //bool? cascade = null;
            //bool? skipCustomListeners = null;
            //bool? skipIoMappings = null;
            //instance.DeleteProcessDefinitionsByKeyAndTenantId(key, tenantId, cascade, skipCustomListeners, skipIoMappings);
            
        }
        /// <summary>
        /// Test GetActivityStatistics
        /// </summary>
        [Test]
        public void GetActivityStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //var response = instance.GetActivityStatistics(id, failedJobs, incidents, incidentsForType);
            //Assert.IsInstanceOf<List<ActivityStatisticsResultDto>> (response, "response is List<ActivityStatisticsResultDto>");
        }
        /// <summary>
        /// Test GetActivityStatisticsByProcessDefinitionKey
        /// </summary>
        [Test]
        public void GetActivityStatisticsByProcessDefinitionKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //var response = instance.GetActivityStatisticsByProcessDefinitionKey(key, failedJobs, incidents, incidentsForType);
            //Assert.IsInstanceOf<List<ActivityStatisticsResultDto>> (response, "response is List<ActivityStatisticsResultDto>");
        }
        /// <summary>
        /// Test GetActivityStatisticsByProcessDefinitionKeyAndTenantId
        /// </summary>
        [Test]
        public void GetActivityStatisticsByProcessDefinitionKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //var response = instance.GetActivityStatisticsByProcessDefinitionKeyAndTenantId(key, tenantId, failedJobs, incidents, incidentsForType);
            //Assert.IsInstanceOf<List<ActivityStatisticsResultDto>> (response, "response is List<ActivityStatisticsResultDto>");
        }
        /// <summary>
        /// Test GetDeployedStartForm
        /// </summary>
        [Test]
        public void GetDeployedStartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetDeployedStartForm(id);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetDeployedStartFormByKey
        /// </summary>
        [Test]
        public void GetDeployedStartFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetDeployedStartFormByKey(key);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetDeployedStartFormByKeyAndTenantId
        /// </summary>
        [Test]
        public void GetDeployedStartFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetDeployedStartFormByKeyAndTenantId(key, tenantId);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetLatestProcessDefinitionByTenantId
        /// </summary>
        [Test]
        public void GetLatestProcessDefinitionByTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetLatestProcessDefinitionByTenantId(key, tenantId);
            //Assert.IsInstanceOf<ProcessDefinitionDto> (response, "response is ProcessDefinitionDto");
        }
        /// <summary>
        /// Test GetProcessDefinition
        /// </summary>
        [Test]
        public void GetProcessDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetProcessDefinition(id);
            //Assert.IsInstanceOf<ProcessDefinitionDto> (response, "response is ProcessDefinitionDto");
        }
        /// <summary>
        /// Test GetProcessDefinitionBpmn20Xml
        /// </summary>
        [Test]
        public void GetProcessDefinitionBpmn20XmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetProcessDefinitionBpmn20Xml(id);
            //Assert.IsInstanceOf<ProcessDefinitionDiagramDto> (response, "response is ProcessDefinitionDiagramDto");
        }
        /// <summary>
        /// Test GetProcessDefinitionBpmn20XmlByKey
        /// </summary>
        [Test]
        public void GetProcessDefinitionBpmn20XmlByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetProcessDefinitionBpmn20XmlByKey(key);
            //Assert.IsInstanceOf<ProcessDefinitionDiagramDto> (response, "response is ProcessDefinitionDiagramDto");
        }
        /// <summary>
        /// Test GetProcessDefinitionBpmn20XmlByKeyAndTenantId
        /// </summary>
        [Test]
        public void GetProcessDefinitionBpmn20XmlByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetProcessDefinitionBpmn20XmlByKeyAndTenantId(key, tenantId);
            //Assert.IsInstanceOf<ProcessDefinitionDiagramDto> (response, "response is ProcessDefinitionDiagramDto");
        }
        /// <summary>
        /// Test GetProcessDefinitionByKey
        /// </summary>
        [Test]
        public void GetProcessDefinitionByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetProcessDefinitionByKey(key);
            //Assert.IsInstanceOf<ProcessDefinitionDto> (response, "response is ProcessDefinitionDto");
        }
        /// <summary>
        /// Test GetProcessDefinitionDiagram
        /// </summary>
        [Test]
        public void GetProcessDefinitionDiagramTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetProcessDefinitionDiagram(id);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetProcessDefinitionDiagramByKey
        /// </summary>
        [Test]
        public void GetProcessDefinitionDiagramByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetProcessDefinitionDiagramByKey(key);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetProcessDefinitionDiagramByKeyAndTenantId
        /// </summary>
        [Test]
        public void GetProcessDefinitionDiagramByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetProcessDefinitionDiagramByKeyAndTenantId(key, tenantId);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetProcessDefinitionStatistics
        /// </summary>
        [Test]
        public void GetProcessDefinitionStatisticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? failedJobs = null;
            //bool? incidents = null;
            //string incidentsForType = null;
            //bool? rootIncidents = null;
            //var response = instance.GetProcessDefinitionStatistics(failedJobs, incidents, incidentsForType, rootIncidents);
            //Assert.IsInstanceOf<List<ProcessDefinitionStatisticsResultDto>> (response, "response is List<ProcessDefinitionStatisticsResultDto>");
        }
        /// <summary>
        /// Test GetProcessDefinitions
        /// </summary>
        [Test]
        public void GetProcessDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processDefinitionId = null;
            //string processDefinitionIdIn = null;
            //string name = null;
            //string nameLike = null;
            //string deploymentId = null;
            //DateTime? deployedAfter = null;
            //DateTime? deployedAt = null;
            //string key = null;
            //string keysIn = null;
            //string keyLike = null;
            //string category = null;
            //string categoryLike = null;
            //int? version = null;
            //bool? latestVersion = null;
            //string resourceName = null;
            //string resourceNameLike = null;
            //string startableBy = null;
            //bool? active = null;
            //bool? suspended = null;
            //string incidentId = null;
            //string incidentType = null;
            //string incidentMessage = null;
            //string incidentMessageLike = null;
            //string tenantIdIn = null;
            //bool? withoutTenantId = null;
            //bool? includeProcessDefinitionsWithoutTenantId = null;
            //string versionTag = null;
            //string versionTagLike = null;
            //bool? withoutVersionTag = null;
            //bool? startableInTasklist = null;
            //bool? notStartableInTasklist = null;
            //bool? startablePermissionCheck = null;
            //string sortBy = null;
            //string sortOrder = null;
            //int? firstResult = null;
            //int? maxResults = null;
            //var response = instance.GetProcessDefinitions(processDefinitionId, processDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keysIn, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, startableBy, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, includeProcessDefinitionsWithoutTenantId, versionTag, versionTagLike, withoutVersionTag, startableInTasklist, notStartableInTasklist, startablePermissionCheck, sortBy, sortOrder, firstResult, maxResults);
            //Assert.IsInstanceOf<List<ProcessDefinitionDto>> (response, "response is List<ProcessDefinitionDto>");
        }
        /// <summary>
        /// Test GetProcessDefinitionsCount
        /// </summary>
        [Test]
        public void GetProcessDefinitionsCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string processDefinitionId = null;
            //string processDefinitionIdIn = null;
            //string name = null;
            //string nameLike = null;
            //string deploymentId = null;
            //DateTime? deployedAfter = null;
            //DateTime? deployedAt = null;
            //string key = null;
            //string keysIn = null;
            //string keyLike = null;
            //string category = null;
            //string categoryLike = null;
            //int? version = null;
            //bool? latestVersion = null;
            //string resourceName = null;
            //string resourceNameLike = null;
            //string startableBy = null;
            //bool? active = null;
            //bool? suspended = null;
            //string incidentId = null;
            //string incidentType = null;
            //string incidentMessage = null;
            //string incidentMessageLike = null;
            //string tenantIdIn = null;
            //bool? withoutTenantId = null;
            //bool? includeProcessDefinitionsWithoutTenantId = null;
            //string versionTag = null;
            //string versionTagLike = null;
            //bool? withoutVersionTag = null;
            //bool? startableInTasklist = null;
            //bool? notStartableInTasklist = null;
            //bool? startablePermissionCheck = null;
            //var response = instance.GetProcessDefinitionsCount(processDefinitionId, processDefinitionIdIn, name, nameLike, deploymentId, deployedAfter, deployedAt, key, keysIn, keyLike, category, categoryLike, version, latestVersion, resourceName, resourceNameLike, startableBy, active, suspended, incidentId, incidentType, incidentMessage, incidentMessageLike, tenantIdIn, withoutTenantId, includeProcessDefinitionsWithoutTenantId, versionTag, versionTagLike, withoutVersionTag, startableInTasklist, notStartableInTasklist, startablePermissionCheck);
            //Assert.IsInstanceOf<CountResultDto> (response, "response is CountResultDto");
        }
        /// <summary>
        /// Test GetRenderedStartForm
        /// </summary>
        [Test]
        public void GetRenderedStartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetRenderedStartForm(id);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetRenderedStartFormByKey
        /// </summary>
        [Test]
        public void GetRenderedStartFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetRenderedStartFormByKey(key);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetRenderedStartFormByKeyAndTenantId
        /// </summary>
        [Test]
        public void GetRenderedStartFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetRenderedStartFormByKeyAndTenantId(key, tenantId);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        /// <summary>
        /// Test GetStartForm
        /// </summary>
        [Test]
        public void GetStartFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetStartForm(id);
            //Assert.IsInstanceOf<FormDto> (response, "response is FormDto");
        }
        /// <summary>
        /// Test GetStartFormByKey
        /// </summary>
        [Test]
        public void GetStartFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetStartFormByKey(key);
            //Assert.IsInstanceOf<FormDto> (response, "response is FormDto");
        }
        /// <summary>
        /// Test GetStartFormByKeyAndTenantId
        /// </summary>
        [Test]
        public void GetStartFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //var response = instance.GetStartFormByKeyAndTenantId(key, tenantId);
            //Assert.IsInstanceOf<FormDto> (response, "response is FormDto");
        }
        /// <summary>
        /// Test GetStartFormVariables
        /// </summary>
        [Test]
        public void GetStartFormVariablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string variableNames = null;
            //bool? deserializeValues = null;
            //var response = instance.GetStartFormVariables(id, variableNames, deserializeValues);
            //Assert.IsInstanceOf<Dictionary<string, VariableValueDto>> (response, "response is Dictionary<string, VariableValueDto>");
        }
        /// <summary>
        /// Test GetStartFormVariablesByKey
        /// </summary>
        [Test]
        public void GetStartFormVariablesByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string variableNames = null;
            //bool? deserializeValues = null;
            //var response = instance.GetStartFormVariablesByKey(key, variableNames, deserializeValues);
            //Assert.IsInstanceOf<Dictionary<string, VariableValueDto>> (response, "response is Dictionary<string, VariableValueDto>");
        }
        /// <summary>
        /// Test GetStartFormVariablesByKeyAndTenantId
        /// </summary>
        [Test]
        public void GetStartFormVariablesByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //string variableNames = null;
            //bool? deserializeValues = null;
            //var response = instance.GetStartFormVariablesByKeyAndTenantId(key, tenantId, variableNames, deserializeValues);
            //Assert.IsInstanceOf<Dictionary<string, VariableValueDto>> (response, "response is Dictionary<string, VariableValueDto>");
        }
        /// <summary>
        /// Test RestartProcessInstance
        /// </summary>
        [Test]
        public void RestartProcessInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //RestartProcessInstanceDto body = null;
            //instance.RestartProcessInstance(id, body);
            
        }
        /// <summary>
        /// Test RestartProcessInstanceAsyncOperation
        /// </summary>
        [Test]
        public void RestartProcessInstanceAsyncOperationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //RestartProcessInstanceDto body = null;
            //var response = instance.RestartProcessInstanceAsyncOperation(id, body);
            //Assert.IsInstanceOf<BatchDto> (response, "response is BatchDto");
        }
        /// <summary>
        /// Test StartProcessInstance
        /// </summary>
        [Test]
        public void StartProcessInstanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //StartProcessInstanceDto body = null;
            //var response = instance.StartProcessInstance(id, body);
            //Assert.IsInstanceOf<ProcessInstanceWithVariablesDto> (response, "response is ProcessInstanceWithVariablesDto");
        }
        /// <summary>
        /// Test StartProcessInstanceByKey
        /// </summary>
        [Test]
        public void StartProcessInstanceByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //StartProcessInstanceDto body = null;
            //var response = instance.StartProcessInstanceByKey(key, body);
            //Assert.IsInstanceOf<ProcessInstanceWithVariablesDto> (response, "response is ProcessInstanceWithVariablesDto");
        }
        /// <summary>
        /// Test StartProcessInstanceByKeyAndTenantId
        /// </summary>
        [Test]
        public void StartProcessInstanceByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //StartProcessInstanceDto body = null;
            //var response = instance.StartProcessInstanceByKeyAndTenantId(key, tenantId, body);
            //Assert.IsInstanceOf<ProcessInstanceWithVariablesDto> (response, "response is ProcessInstanceWithVariablesDto");
        }
        /// <summary>
        /// Test SubmitForm
        /// </summary>
        [Test]
        public void SubmitFormTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //StartProcessInstanceFormDto body = null;
            //var response = instance.SubmitForm(id, body);
            //Assert.IsInstanceOf<ProcessInstanceDto> (response, "response is ProcessInstanceDto");
        }
        /// <summary>
        /// Test SubmitFormByKey
        /// </summary>
        [Test]
        public void SubmitFormByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //StartProcessInstanceFormDto body = null;
            //var response = instance.SubmitFormByKey(key, body);
            //Assert.IsInstanceOf<ProcessInstanceDto> (response, "response is ProcessInstanceDto");
        }
        /// <summary>
        /// Test SubmitFormByKeyAndTenantId
        /// </summary>
        [Test]
        public void SubmitFormByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //StartProcessInstanceFormDto body = null;
            //var response = instance.SubmitFormByKeyAndTenantId(key, tenantId, body);
            //Assert.IsInstanceOf<ProcessInstanceDto> (response, "response is ProcessInstanceDto");
        }
        /// <summary>
        /// Test UpdateHistoryTimeToLiveByProcessDefinitionId
        /// </summary>
        [Test]
        public void UpdateHistoryTimeToLiveByProcessDefinitionIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //HistoryTimeToLiveDto body = null;
            //instance.UpdateHistoryTimeToLiveByProcessDefinitionId(id, body);
            
        }
        /// <summary>
        /// Test UpdateHistoryTimeToLiveByProcessDefinitionKey
        /// </summary>
        [Test]
        public void UpdateHistoryTimeToLiveByProcessDefinitionKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //HistoryTimeToLiveDto body = null;
            //instance.UpdateHistoryTimeToLiveByProcessDefinitionKey(key, body);
            
        }
        /// <summary>
        /// Test UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId
        /// </summary>
        [Test]
        public void UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //HistoryTimeToLiveDto body = null;
            //instance.UpdateHistoryTimeToLiveByProcessDefinitionKeyAndTenantId(key, tenantId, body);
            
        }
        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionState
        /// </summary>
        [Test]
        public void UpdateProcessDefinitionSuspensionStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProcessDefinitionSuspensionStateDto body = null;
            //instance.UpdateProcessDefinitionSuspensionState(body);
            
        }
        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionStateById
        /// </summary>
        [Test]
        public void UpdateProcessDefinitionSuspensionStateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ProcessDefinitionSuspensionStateDto body = null;
            //instance.UpdateProcessDefinitionSuspensionStateById(id, body);
            
        }
        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionStateByKey
        /// </summary>
        [Test]
        public void UpdateProcessDefinitionSuspensionStateByKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //ProcessDefinitionSuspensionStateDto body = null;
            //instance.UpdateProcessDefinitionSuspensionStateByKey(key, body);
            
        }
        /// <summary>
        /// Test UpdateProcessDefinitionSuspensionStateByKeyAndTenantId
        /// </summary>
        [Test]
        public void UpdateProcessDefinitionSuspensionStateByKeyAndTenantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string tenantId = null;
            //ProcessDefinitionSuspensionStateDto body = null;
            //instance.UpdateProcessDefinitionSuspensionStateByKeyAndTenantId(key, tenantId, body);
            
        }
    }

}
