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
    /// ProcessDefinitionStatisticsResultDto
    /// </summary>
    [DataContract]
        public partial class ProcessDefinitionStatisticsResultDto :  IEquatable<ProcessDefinitionStatisticsResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDefinitionStatisticsResultDto" /> class.
        /// </summary>
        /// <param name="id">The id of the process definition the results are aggregated for..</param>
        /// <param name="instances">The total number of running process instances of this process definition..</param>
        /// <param name="failedJobs">The total number of failed jobs for the running instances. **Note**: Will be &#x60;0&#x60; (not &#x60;null&#x60;), if failed jobs were excluded..</param>
        /// <param name="incidents">Each item in the resulting array is an object which contains &#x60;incidentType&#x60; and &#x60;incidentCount&#x60;. **Note**: Will be an empty array, if &#x60;incidents&#x60; or &#x60;incidentsForType&#x60; were excluded. Furthermore, the array will be also empty if no incidents were found..</param>
        /// <param name="definition">definition.</param>
        public ProcessDefinitionStatisticsResultDto(string id = default(string), int? instances = default(int?), int? failedJobs = default(int?), List<IncidentStatisticsResultDto> incidents = default(List<IncidentStatisticsResultDto>), ProcessDefinitionDto definition = default(ProcessDefinitionDto))
        {
            this.Id = id;
            this.Instances = instances;
            this.FailedJobs = failedJobs;
            this.Incidents = incidents;
            this.Definition = definition;
        }
        
        /// <summary>
        /// The id of the process definition the results are aggregated for.
        /// </summary>
        /// <value>The id of the process definition the results are aggregated for.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The total number of running process instances of this process definition.
        /// </summary>
        /// <value>The total number of running process instances of this process definition.</value>
        [DataMember(Name="instances", EmitDefaultValue=false)]
        public int? Instances { get; set; }

        /// <summary>
        /// The total number of failed jobs for the running instances. **Note**: Will be &#x60;0&#x60; (not &#x60;null&#x60;), if failed jobs were excluded.
        /// </summary>
        /// <value>The total number of failed jobs for the running instances. **Note**: Will be &#x60;0&#x60; (not &#x60;null&#x60;), if failed jobs were excluded.</value>
        [DataMember(Name="failedJobs", EmitDefaultValue=false)]
        public int? FailedJobs { get; set; }

        /// <summary>
        /// Each item in the resulting array is an object which contains &#x60;incidentType&#x60; and &#x60;incidentCount&#x60;. **Note**: Will be an empty array, if &#x60;incidents&#x60; or &#x60;incidentsForType&#x60; were excluded. Furthermore, the array will be also empty if no incidents were found.
        /// </summary>
        /// <value>Each item in the resulting array is an object which contains &#x60;incidentType&#x60; and &#x60;incidentCount&#x60;. **Note**: Will be an empty array, if &#x60;incidents&#x60; or &#x60;incidentsForType&#x60; were excluded. Furthermore, the array will be also empty if no incidents were found.</value>
        [DataMember(Name="incidents", EmitDefaultValue=false)]
        public List<IncidentStatisticsResultDto> Incidents { get; set; }

        /// <summary>
        /// Gets or Sets Definition
        /// </summary>
        [DataMember(Name="definition", EmitDefaultValue=false)]
        public ProcessDefinitionDto Definition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessDefinitionStatisticsResultDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  FailedJobs: ").Append(FailedJobs).Append("\n");
            sb.Append("  Incidents: ").Append(Incidents).Append("\n");
            sb.Append("  Definition: ").Append(Definition).Append("\n");
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
            return this.Equals(input as ProcessDefinitionStatisticsResultDto);
        }

        /// <summary>
        /// Returns true if ProcessDefinitionStatisticsResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessDefinitionStatisticsResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessDefinitionStatisticsResultDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Instances == input.Instances ||
                    (this.Instances != null &&
                    this.Instances.Equals(input.Instances))
                ) && 
                (
                    this.FailedJobs == input.FailedJobs ||
                    (this.FailedJobs != null &&
                    this.FailedJobs.Equals(input.FailedJobs))
                ) && 
                (
                    this.Incidents == input.Incidents ||
                    this.Incidents != null &&
                    input.Incidents != null &&
                    this.Incidents.SequenceEqual(input.Incidents)
                ) && 
                (
                    this.Definition == input.Definition ||
                    (this.Definition != null &&
                    this.Definition.Equals(input.Definition))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.FailedJobs != null)
                    hashCode = hashCode * 59 + this.FailedJobs.GetHashCode();
                if (this.Incidents != null)
                    hashCode = hashCode * 59 + this.Incidents.GetHashCode();
                if (this.Definition != null)
                    hashCode = hashCode * 59 + this.Definition.GetHashCode();
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
