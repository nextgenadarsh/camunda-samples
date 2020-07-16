/* 
 * Camunda BPM REST API
 *
 * OpenApi Spec for Camunda BPM REST API.
 *
 * OpenAPI spec version: 7.13.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Camunda.Client.Api;
using Camunda.Client.Model;
using Camunda.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Camunda.Client.Test
{
    /// <summary>
    ///  Class for testing ProcessInstanceQueryDto
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProcessInstanceQueryDtoTests
    {
        // TODO uncomment below to declare an instance variable for ProcessInstanceQueryDto
        //private ProcessInstanceQueryDto instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProcessInstanceQueryDto
            //instance = new ProcessInstanceQueryDto();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProcessInstanceQueryDto
        /// </summary>
        [Test]
        public void ProcessInstanceQueryDtoInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProcessInstanceQueryDto
            //Assert.IsInstanceOfType<ProcessInstanceQueryDto> (instance, "variable 'instance' is a ProcessInstanceQueryDto");
        }


        /// <summary>
        /// Test the property 'DeploymentId'
        /// </summary>
        [Test]
        public void DeploymentIdTest()
        {
            // TODO unit test for the property 'DeploymentId'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionId'
        /// </summary>
        [Test]
        public void ProcessDefinitionIdTest()
        {
            // TODO unit test for the property 'ProcessDefinitionId'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionKey'
        /// </summary>
        [Test]
        public void ProcessDefinitionKeyTest()
        {
            // TODO unit test for the property 'ProcessDefinitionKey'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionKeyIn'
        /// </summary>
        [Test]
        public void ProcessDefinitionKeyInTest()
        {
            // TODO unit test for the property 'ProcessDefinitionKeyIn'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionKeyNotIn'
        /// </summary>
        [Test]
        public void ProcessDefinitionKeyNotInTest()
        {
            // TODO unit test for the property 'ProcessDefinitionKeyNotIn'
        }
        /// <summary>
        /// Test the property 'BusinessKey'
        /// </summary>
        [Test]
        public void BusinessKeyTest()
        {
            // TODO unit test for the property 'BusinessKey'
        }
        /// <summary>
        /// Test the property 'BusinessKeyLike'
        /// </summary>
        [Test]
        public void BusinessKeyLikeTest()
        {
            // TODO unit test for the property 'BusinessKeyLike'
        }
        /// <summary>
        /// Test the property 'CaseInstanceId'
        /// </summary>
        [Test]
        public void CaseInstanceIdTest()
        {
            // TODO unit test for the property 'CaseInstanceId'
        }
        /// <summary>
        /// Test the property 'SuperProcessInstance'
        /// </summary>
        [Test]
        public void SuperProcessInstanceTest()
        {
            // TODO unit test for the property 'SuperProcessInstance'
        }
        /// <summary>
        /// Test the property 'SubProcessInstance'
        /// </summary>
        [Test]
        public void SubProcessInstanceTest()
        {
            // TODO unit test for the property 'SubProcessInstance'
        }
        /// <summary>
        /// Test the property 'SuperCaseInstance'
        /// </summary>
        [Test]
        public void SuperCaseInstanceTest()
        {
            // TODO unit test for the property 'SuperCaseInstance'
        }
        /// <summary>
        /// Test the property 'SubCaseInstance'
        /// </summary>
        [Test]
        public void SubCaseInstanceTest()
        {
            // TODO unit test for the property 'SubCaseInstance'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'Suspended'
        /// </summary>
        [Test]
        public void SuspendedTest()
        {
            // TODO unit test for the property 'Suspended'
        }
        /// <summary>
        /// Test the property 'ProcessInstanceIds'
        /// </summary>
        [Test]
        public void ProcessInstanceIdsTest()
        {
            // TODO unit test for the property 'ProcessInstanceIds'
        }
        /// <summary>
        /// Test the property 'WithIncident'
        /// </summary>
        [Test]
        public void WithIncidentTest()
        {
            // TODO unit test for the property 'WithIncident'
        }
        /// <summary>
        /// Test the property 'IncidentId'
        /// </summary>
        [Test]
        public void IncidentIdTest()
        {
            // TODO unit test for the property 'IncidentId'
        }
        /// <summary>
        /// Test the property 'IncidentType'
        /// </summary>
        [Test]
        public void IncidentTypeTest()
        {
            // TODO unit test for the property 'IncidentType'
        }
        /// <summary>
        /// Test the property 'IncidentMessage'
        /// </summary>
        [Test]
        public void IncidentMessageTest()
        {
            // TODO unit test for the property 'IncidentMessage'
        }
        /// <summary>
        /// Test the property 'IncidentMessageLike'
        /// </summary>
        [Test]
        public void IncidentMessageLikeTest()
        {
            // TODO unit test for the property 'IncidentMessageLike'
        }
        /// <summary>
        /// Test the property 'TenantIdIn'
        /// </summary>
        [Test]
        public void TenantIdInTest()
        {
            // TODO unit test for the property 'TenantIdIn'
        }
        /// <summary>
        /// Test the property 'WithoutTenantId'
        /// </summary>
        [Test]
        public void WithoutTenantIdTest()
        {
            // TODO unit test for the property 'WithoutTenantId'
        }
        /// <summary>
        /// Test the property 'ProcessDefinitionWithoutTenantId'
        /// </summary>
        [Test]
        public void ProcessDefinitionWithoutTenantIdTest()
        {
            // TODO unit test for the property 'ProcessDefinitionWithoutTenantId'
        }
        /// <summary>
        /// Test the property 'ActivityIdIn'
        /// </summary>
        [Test]
        public void ActivityIdInTest()
        {
            // TODO unit test for the property 'ActivityIdIn'
        }
        /// <summary>
        /// Test the property 'RootProcessInstances'
        /// </summary>
        [Test]
        public void RootProcessInstancesTest()
        {
            // TODO unit test for the property 'RootProcessInstances'
        }
        /// <summary>
        /// Test the property 'LeafProcessInstances'
        /// </summary>
        [Test]
        public void LeafProcessInstancesTest()
        {
            // TODO unit test for the property 'LeafProcessInstances'
        }
        /// <summary>
        /// Test the property 'Variables'
        /// </summary>
        [Test]
        public void VariablesTest()
        {
            // TODO unit test for the property 'Variables'
        }
        /// <summary>
        /// Test the property 'VariableNamesIgnoreCase'
        /// </summary>
        [Test]
        public void VariableNamesIgnoreCaseTest()
        {
            // TODO unit test for the property 'VariableNamesIgnoreCase'
        }
        /// <summary>
        /// Test the property 'VariableValuesIgnoreCase'
        /// </summary>
        [Test]
        public void VariableValuesIgnoreCaseTest()
        {
            // TODO unit test for the property 'VariableValuesIgnoreCase'
        }
        /// <summary>
        /// Test the property 'OrQueries'
        /// </summary>
        [Test]
        public void OrQueriesTest()
        {
            // TODO unit test for the property 'OrQueries'
        }
        /// <summary>
        /// Test the property 'Sorting'
        /// </summary>
        [Test]
        public void SortingTest()
        {
            // TODO unit test for the property 'Sorting'
        }

    }

}