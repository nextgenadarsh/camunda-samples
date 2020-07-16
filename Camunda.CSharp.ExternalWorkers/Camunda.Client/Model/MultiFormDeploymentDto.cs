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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Camunda.Client.Client.SwaggerDateConverter;

namespace Camunda.Client.Model
{
    /// <summary>
    /// MultiFormDeploymentDto
    /// </summary>
    [DataContract]
        public partial class MultiFormDeploymentDto :  IEquatable<MultiFormDeploymentDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiFormDeploymentDto" /> class.
        /// </summary>
        /// <param name="tenantId">The tenant id for the deployment to be created..</param>
        /// <param name="deploymentSource">The source for the deployment to be created..</param>
        /// <param name="deployChangedOnly">A flag indicating whether the process engine should perform duplicate checking on a per-resource basis. If set to true, only those resources that have actually changed are deployed. Checks are made against resources included previous deployments of the same name and only against the latest versions of those resources. If set to true, the option enable-duplicate-filtering is overridden and set to true. (default to false).</param>
        /// <param name="enableDuplicateFiltering">A flag indicating whether the process engine should perform duplicate checking for the deployment or not. This allows you to check if a deployment with the same name and the same resouces already exists and if true, not create a new deployment but instead return the existing deployment. The default value is false. (default to false).</param>
        /// <param name="deploymentName">The name for the deployment to be created..</param>
        /// <param name="data">The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment..</param>
        public MultiFormDeploymentDto(string tenantId = default(string), string deploymentSource = default(string), bool? deployChangedOnly = false, bool? enableDuplicateFiltering = false, string deploymentName = default(string), byte[] data = default(byte[]))
        {
            this.TenantId = tenantId;
            this.DeploymentSource = deploymentSource;
            // use default value if no "deployChangedOnly" provided
            if (deployChangedOnly == null)
            {
                this.DeployChangedOnly = false;
            }
            else
            {
                this.DeployChangedOnly = deployChangedOnly;
            }
            // use default value if no "enableDuplicateFiltering" provided
            if (enableDuplicateFiltering == null)
            {
                this.EnableDuplicateFiltering = false;
            }
            else
            {
                this.EnableDuplicateFiltering = enableDuplicateFiltering;
            }
            this.DeploymentName = deploymentName;
            this.Data = data;
        }
        
        /// <summary>
        /// The tenant id for the deployment to be created.
        /// </summary>
        /// <value>The tenant id for the deployment to be created.</value>
        [DataMember(Name="tenant-id", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// The source for the deployment to be created.
        /// </summary>
        /// <value>The source for the deployment to be created.</value>
        [DataMember(Name="deployment-source", EmitDefaultValue=false)]
        public string DeploymentSource { get; set; }

        /// <summary>
        /// A flag indicating whether the process engine should perform duplicate checking on a per-resource basis. If set to true, only those resources that have actually changed are deployed. Checks are made against resources included previous deployments of the same name and only against the latest versions of those resources. If set to true, the option enable-duplicate-filtering is overridden and set to true.
        /// </summary>
        /// <value>A flag indicating whether the process engine should perform duplicate checking on a per-resource basis. If set to true, only those resources that have actually changed are deployed. Checks are made against resources included previous deployments of the same name and only against the latest versions of those resources. If set to true, the option enable-duplicate-filtering is overridden and set to true.</value>
        [DataMember(Name="deploy-changed-only", EmitDefaultValue=false)]
        public bool? DeployChangedOnly { get; set; }

        /// <summary>
        /// A flag indicating whether the process engine should perform duplicate checking for the deployment or not. This allows you to check if a deployment with the same name and the same resouces already exists and if true, not create a new deployment but instead return the existing deployment. The default value is false.
        /// </summary>
        /// <value>A flag indicating whether the process engine should perform duplicate checking for the deployment or not. This allows you to check if a deployment with the same name and the same resouces already exists and if true, not create a new deployment but instead return the existing deployment. The default value is false.</value>
        [DataMember(Name="enable-duplicate-filtering", EmitDefaultValue=false)]
        public bool? EnableDuplicateFiltering { get; set; }

        /// <summary>
        /// The name for the deployment to be created.
        /// </summary>
        /// <value>The name for the deployment to be created.</value>
        [DataMember(Name="deployment-name", EmitDefaultValue=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment.
        /// </summary>
        /// <value>The binary data to create the deployment resource. It is possible to have more than one form part with different form part names for the binary data to create a deployment.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiFormDeploymentDto {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  DeploymentSource: ").Append(DeploymentSource).Append("\n");
            sb.Append("  DeployChangedOnly: ").Append(DeployChangedOnly).Append("\n");
            sb.Append("  EnableDuplicateFiltering: ").Append(EnableDuplicateFiltering).Append("\n");
            sb.Append("  DeploymentName: ").Append(DeploymentName).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiFormDeploymentDto);
        }

        /// <summary>
        /// Returns true if MultiFormDeploymentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiFormDeploymentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiFormDeploymentDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.DeploymentSource == input.DeploymentSource ||
                    (this.DeploymentSource != null &&
                    this.DeploymentSource.Equals(input.DeploymentSource))
                ) && 
                (
                    this.DeployChangedOnly == input.DeployChangedOnly ||
                    (this.DeployChangedOnly != null &&
                    this.DeployChangedOnly.Equals(input.DeployChangedOnly))
                ) && 
                (
                    this.EnableDuplicateFiltering == input.EnableDuplicateFiltering ||
                    (this.EnableDuplicateFiltering != null &&
                    this.EnableDuplicateFiltering.Equals(input.EnableDuplicateFiltering))
                ) && 
                (
                    this.DeploymentName == input.DeploymentName ||
                    (this.DeploymentName != null &&
                    this.DeploymentName.Equals(input.DeploymentName))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.DeploymentSource != null)
                    hashCode = hashCode * 59 + this.DeploymentSource.GetHashCode();
                if (this.DeployChangedOnly != null)
                    hashCode = hashCode * 59 + this.DeployChangedOnly.GetHashCode();
                if (this.EnableDuplicateFiltering != null)
                    hashCode = hashCode * 59 + this.EnableDuplicateFiltering.GetHashCode();
                if (this.DeploymentName != null)
                    hashCode = hashCode * 59 + this.DeploymentName.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
