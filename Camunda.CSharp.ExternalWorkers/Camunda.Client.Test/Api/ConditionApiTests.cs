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
    ///  Class for testing ConditionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConditionApiTests
    {
        private ConditionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConditionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConditionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConditionApi
            //Assert.IsInstanceOfType(typeof(ConditionApi), instance, "instance is a ConditionApi");
        }

        /// <summary>
        /// Test EvaluateCondition
        /// </summary>
        [Test]
        public void EvaluateConditionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EvaluationConditionDto body = null;
            //var response = instance.EvaluateCondition(body);
            //Assert.IsInstanceOf<List<ProcessInstanceDto>> (response, "response is List<ProcessInstanceDto>");
        }
    }

}
