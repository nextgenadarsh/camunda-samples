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
    /// ResourceReportDto
    /// </summary>
    [DataContract]
        public partial class ResourceReportDto :  IEquatable<ResourceReportDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceReportDto" /> class.
        /// </summary>
        /// <param name="errors">A list of errors occurred during parsing..</param>
        /// <param name="warnings">A list of warnings occurred during parsing..</param>
        public ResourceReportDto(List<ProblemDto> errors = default(List<ProblemDto>), List<ProblemDto> warnings = default(List<ProblemDto>))
        {
            this.Errors = errors;
            this.Warnings = warnings;
        }
        
        /// <summary>
        /// A list of errors occurred during parsing.
        /// </summary>
        /// <value>A list of errors occurred during parsing.</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ProblemDto> Errors { get; set; }

        /// <summary>
        /// A list of warnings occurred during parsing.
        /// </summary>
        /// <value>A list of warnings occurred during parsing.</value>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<ProblemDto> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceReportDto {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as ResourceReportDto);
        }

        /// <summary>
        /// Returns true if ResourceReportDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceReportDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceReportDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
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
