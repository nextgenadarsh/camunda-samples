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
    /// SetJobRetriesByProcessDto
    /// </summary>
    [DataContract]
        public partial class SetJobRetriesByProcessDto :  IEquatable<SetJobRetriesByProcessDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetJobRetriesByProcessDto" /> class.
        /// </summary>
        /// <param name="processInstances">A list of process instance ids to fetch jobs, for which retries will be set..</param>
        /// <param name="retries">An integer representing the number of retries. Please note that the value cannot be negative or null..</param>
        /// <param name="processInstanceQuery">processInstanceQuery.</param>
        /// <param name="historicProcessInstanceQuery">historicProcessInstanceQuery.</param>
        public SetJobRetriesByProcessDto(List<string> processInstances = default(List<string>), int? retries = default(int?), ProcessInstanceQueryDto processInstanceQuery = default(ProcessInstanceQueryDto), HistoricProcessInstanceQueryDto historicProcessInstanceQuery = default(HistoricProcessInstanceQueryDto))
        {
            this.ProcessInstances = processInstances;
            this.Retries = retries;
            this.ProcessInstanceQuery = processInstanceQuery;
            this.HistoricProcessInstanceQuery = historicProcessInstanceQuery;
        }
        
        /// <summary>
        /// A list of process instance ids to fetch jobs, for which retries will be set.
        /// </summary>
        /// <value>A list of process instance ids to fetch jobs, for which retries will be set.</value>
        [DataMember(Name="processInstances", EmitDefaultValue=false)]
        public List<string> ProcessInstances { get; set; }

        /// <summary>
        /// An integer representing the number of retries. Please note that the value cannot be negative or null.
        /// </summary>
        /// <value>An integer representing the number of retries. Please note that the value cannot be negative or null.</value>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int? Retries { get; set; }

        /// <summary>
        /// Gets or Sets ProcessInstanceQuery
        /// </summary>
        [DataMember(Name="processInstanceQuery", EmitDefaultValue=false)]
        public ProcessInstanceQueryDto ProcessInstanceQuery { get; set; }

        /// <summary>
        /// Gets or Sets HistoricProcessInstanceQuery
        /// </summary>
        [DataMember(Name="historicProcessInstanceQuery", EmitDefaultValue=false)]
        public HistoricProcessInstanceQueryDto HistoricProcessInstanceQuery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetJobRetriesByProcessDto {\n");
            sb.Append("  ProcessInstances: ").Append(ProcessInstances).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  ProcessInstanceQuery: ").Append(ProcessInstanceQuery).Append("\n");
            sb.Append("  HistoricProcessInstanceQuery: ").Append(HistoricProcessInstanceQuery).Append("\n");
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
            return this.Equals(input as SetJobRetriesByProcessDto);
        }

        /// <summary>
        /// Returns true if SetJobRetriesByProcessDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SetJobRetriesByProcessDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetJobRetriesByProcessDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessInstances == input.ProcessInstances ||
                    this.ProcessInstances != null &&
                    input.ProcessInstances != null &&
                    this.ProcessInstances.SequenceEqual(input.ProcessInstances)
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.ProcessInstanceQuery == input.ProcessInstanceQuery ||
                    (this.ProcessInstanceQuery != null &&
                    this.ProcessInstanceQuery.Equals(input.ProcessInstanceQuery))
                ) && 
                (
                    this.HistoricProcessInstanceQuery == input.HistoricProcessInstanceQuery ||
                    (this.HistoricProcessInstanceQuery != null &&
                    this.HistoricProcessInstanceQuery.Equals(input.HistoricProcessInstanceQuery))
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
                if (this.ProcessInstances != null)
                    hashCode = hashCode * 59 + this.ProcessInstances.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.ProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceQuery.GetHashCode();
                if (this.HistoricProcessInstanceQuery != null)
                    hashCode = hashCode * 59 + this.HistoricProcessInstanceQuery.GetHashCode();
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
