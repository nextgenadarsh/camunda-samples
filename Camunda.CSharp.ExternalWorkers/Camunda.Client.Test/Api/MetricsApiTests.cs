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
    ///  Class for testing MetricsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MetricsApiTests
    {
        private MetricsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MetricsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MetricsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MetricsApi
            //Assert.IsInstanceOfType(typeof(MetricsApi), instance, "instance is a MetricsApi");
        }

        /// <summary>
        /// Test GetMetrics
        /// </summary>
        [Test]
        public void GetMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metricsName = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //var response = instance.GetMetrics(metricsName, startDate, endDate);
            //Assert.IsInstanceOf<MetricsResultDto> (response, "response is MetricsResultDto");
        }
        /// <summary>
        /// Test Interval
        /// </summary>
        [Test]
        public void IntervalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string reporter = null;
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //int? firstResult = null;
            //int? maxResults = null;
            //string interval = null;
            //string aggregateByReporter = null;
            //var response = instance.Interval(name, reporter, startDate, endDate, firstResult, maxResults, interval, aggregateByReporter);
            //Assert.IsInstanceOf<List<MetricsIntervalResultDto>> (response, "response is List<MetricsIntervalResultDto>");
        }
    }

}
