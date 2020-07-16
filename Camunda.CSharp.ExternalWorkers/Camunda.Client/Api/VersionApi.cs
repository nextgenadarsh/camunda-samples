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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Camunda.Client.Client;
using Camunda.Client.Model;

namespace Camunda.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IVersionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves the version of the Rest API.
        /// </remarks>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionDto</returns>
        VersionDto GetRestAPIVersion ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves the version of the Rest API.
        /// </remarks>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionDto</returns>
        ApiResponse<VersionDto> GetRestAPIVersionWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves the version of the Rest API.
        /// </remarks>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionDto</returns>
        System.Threading.Tasks.Task<VersionDto> GetRestAPIVersionAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Retrieves the version of the Rest API.
        /// </remarks>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<VersionDto>> GetRestAPIVersionAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class VersionApi : IVersionApi
    {
        private Camunda.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VersionApi(String basePath)
        {
            this.Configuration = new Camunda.Client.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Camunda.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionApi"/> class
        /// </summary>
        /// <returns></returns>
        public VersionApi()
        {
            this.Configuration = Camunda.Client.Client.Configuration.Default;

            ExceptionFactory = Camunda.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VersionApi(Camunda.Client.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Camunda.Client.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Camunda.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Camunda.Client.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Camunda.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  Retrieves the version of the Rest API.
        /// </summary>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VersionDto</returns>
        public VersionDto GetRestAPIVersion ()
        {
             ApiResponse<VersionDto> localVarResponse = GetRestAPIVersionWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Retrieves the version of the Rest API.
        /// </summary>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VersionDto</returns>
        public ApiResponse< VersionDto > GetRestAPIVersionWithHttpInfo ()
        {

            var localVarPath = "/version";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRestAPIVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VersionDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionDto)));
        }

        /// <summary>
        ///  Retrieves the version of the Rest API.
        /// </summary>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VersionDto</returns>
        public async System.Threading.Tasks.Task<VersionDto> GetRestAPIVersionAsync ()
        {
             ApiResponse<VersionDto> localVarResponse = await GetRestAPIVersionAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Retrieves the version of the Rest API.
        /// </summary>
        /// <exception cref="Camunda.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VersionDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VersionDto>> GetRestAPIVersionAsyncWithHttpInfo ()
        {

            var localVarPath = "/version";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRestAPIVersion", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VersionDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VersionDto) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VersionDto)));
        }

    }
}
