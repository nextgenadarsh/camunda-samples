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
    /// PatchVariablesDto
    /// </summary>
    [DataContract]
        public partial class PatchVariablesDto :  IEquatable<PatchVariablesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchVariablesDto" /> class.
        /// </summary>
        /// <param name="modifications">A JSON object containing variable key-value pairs..</param>
        /// <param name="deletions">An array of String keys of variables to be deleted..</param>
        public PatchVariablesDto(Dictionary<string, VariableValueDto> modifications = default(Dictionary<string, VariableValueDto>), List<string> deletions = default(List<string>))
        {
            this.Modifications = modifications;
            this.Deletions = deletions;
        }
        
        /// <summary>
        /// A JSON object containing variable key-value pairs.
        /// </summary>
        /// <value>A JSON object containing variable key-value pairs.</value>
        [DataMember(Name="modifications", EmitDefaultValue=false)]
        public Dictionary<string, VariableValueDto> Modifications { get; set; }

        /// <summary>
        /// An array of String keys of variables to be deleted.
        /// </summary>
        /// <value>An array of String keys of variables to be deleted.</value>
        [DataMember(Name="deletions", EmitDefaultValue=false)]
        public List<string> Deletions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatchVariablesDto {\n");
            sb.Append("  Modifications: ").Append(Modifications).Append("\n");
            sb.Append("  Deletions: ").Append(Deletions).Append("\n");
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
            return this.Equals(input as PatchVariablesDto);
        }

        /// <summary>
        /// Returns true if PatchVariablesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchVariablesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchVariablesDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Modifications == input.Modifications ||
                    this.Modifications != null &&
                    input.Modifications != null &&
                    this.Modifications.SequenceEqual(input.Modifications)
                ) && 
                (
                    this.Deletions == input.Deletions ||
                    this.Deletions != null &&
                    input.Deletions != null &&
                    this.Deletions.SequenceEqual(input.Deletions)
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
                if (this.Modifications != null)
                    hashCode = hashCode * 59 + this.Modifications.GetHashCode();
                if (this.Deletions != null)
                    hashCode = hashCode * 59 + this.Deletions.GetHashCode();
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