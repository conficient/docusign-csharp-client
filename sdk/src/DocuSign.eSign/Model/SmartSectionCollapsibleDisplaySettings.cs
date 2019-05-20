/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// SmartSectionCollapsibleDisplaySettings
    /// </summary>
    [DataContract]
    public partial class SmartSectionCollapsibleDisplaySettings :  IEquatable<SmartSectionCollapsibleDisplaySettings>, IValidatableObject
    {
        public SmartSectionCollapsibleDisplaySettings()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmartSectionCollapsibleDisplaySettings" /> class.
        /// </summary>
        /// <param name="ArrowClosed">.</param>
        /// <param name="ArrowColor">.</param>
        /// <param name="ArrowLocation">.</param>
        /// <param name="ArrowOpen">.</param>
        /// <param name="ArrowSize">.</param>
        /// <param name="ArrowStyle">.</param>
        /// <param name="ContainerStyle">.</param>
        /// <param name="LabelStyle">.</param>
        /// <param name="OnlyArrowIsClickable">.</param>
        /// <param name="OuterLabelAndArrowStyle">.</param>
        public SmartSectionCollapsibleDisplaySettings(string ArrowClosed = default(string), string ArrowColor = default(string), string ArrowLocation = default(string), string ArrowOpen = default(string), string ArrowSize = default(string), string ArrowStyle = default(string), string ContainerStyle = default(string), string LabelStyle = default(string), bool? OnlyArrowIsClickable = default(bool?), string OuterLabelAndArrowStyle = default(string))
        {
            this.ArrowClosed = ArrowClosed;
            this.ArrowColor = ArrowColor;
            this.ArrowLocation = ArrowLocation;
            this.ArrowOpen = ArrowOpen;
            this.ArrowSize = ArrowSize;
            this.ArrowStyle = ArrowStyle;
            this.ContainerStyle = ContainerStyle;
            this.LabelStyle = LabelStyle;
            this.OnlyArrowIsClickable = OnlyArrowIsClickable;
            this.OuterLabelAndArrowStyle = OuterLabelAndArrowStyle;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="arrowClosed", EmitDefaultValue=false)]
        public string ArrowClosed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="arrowColor", EmitDefaultValue=false)]
        public string ArrowColor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="arrowLocation", EmitDefaultValue=false)]
        public string ArrowLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="arrowOpen", EmitDefaultValue=false)]
        public string ArrowOpen { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="arrowSize", EmitDefaultValue=false)]
        public string ArrowSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="arrowStyle", EmitDefaultValue=false)]
        public string ArrowStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="containerStyle", EmitDefaultValue=false)]
        public string ContainerStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="labelStyle", EmitDefaultValue=false)]
        public string LabelStyle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="onlyArrowIsClickable", EmitDefaultValue=false)]
        public bool? OnlyArrowIsClickable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="outerLabelAndArrowStyle", EmitDefaultValue=false)]
        public string OuterLabelAndArrowStyle { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartSectionCollapsibleDisplaySettings {\n");
            sb.Append("  ArrowClosed: ").Append(ArrowClosed).Append("\n");
            sb.Append("  ArrowColor: ").Append(ArrowColor).Append("\n");
            sb.Append("  ArrowLocation: ").Append(ArrowLocation).Append("\n");
            sb.Append("  ArrowOpen: ").Append(ArrowOpen).Append("\n");
            sb.Append("  ArrowSize: ").Append(ArrowSize).Append("\n");
            sb.Append("  ArrowStyle: ").Append(ArrowStyle).Append("\n");
            sb.Append("  ContainerStyle: ").Append(ContainerStyle).Append("\n");
            sb.Append("  LabelStyle: ").Append(LabelStyle).Append("\n");
            sb.Append("  OnlyArrowIsClickable: ").Append(OnlyArrowIsClickable).Append("\n");
            sb.Append("  OuterLabelAndArrowStyle: ").Append(OuterLabelAndArrowStyle).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SmartSectionCollapsibleDisplaySettings);
        }

        /// <summary>
        /// Returns true if SmartSectionCollapsibleDisplaySettings instances are equal
        /// </summary>
        /// <param name="other">Instance of SmartSectionCollapsibleDisplaySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmartSectionCollapsibleDisplaySettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ArrowClosed == other.ArrowClosed ||
                    this.ArrowClosed != null &&
                    this.ArrowClosed.Equals(other.ArrowClosed)
                ) && 
                (
                    this.ArrowColor == other.ArrowColor ||
                    this.ArrowColor != null &&
                    this.ArrowColor.Equals(other.ArrowColor)
                ) && 
                (
                    this.ArrowLocation == other.ArrowLocation ||
                    this.ArrowLocation != null &&
                    this.ArrowLocation.Equals(other.ArrowLocation)
                ) && 
                (
                    this.ArrowOpen == other.ArrowOpen ||
                    this.ArrowOpen != null &&
                    this.ArrowOpen.Equals(other.ArrowOpen)
                ) && 
                (
                    this.ArrowSize == other.ArrowSize ||
                    this.ArrowSize != null &&
                    this.ArrowSize.Equals(other.ArrowSize)
                ) && 
                (
                    this.ArrowStyle == other.ArrowStyle ||
                    this.ArrowStyle != null &&
                    this.ArrowStyle.Equals(other.ArrowStyle)
                ) && 
                (
                    this.ContainerStyle == other.ContainerStyle ||
                    this.ContainerStyle != null &&
                    this.ContainerStyle.Equals(other.ContainerStyle)
                ) && 
                (
                    this.LabelStyle == other.LabelStyle ||
                    this.LabelStyle != null &&
                    this.LabelStyle.Equals(other.LabelStyle)
                ) && 
                (
                    this.OnlyArrowIsClickable == other.OnlyArrowIsClickable ||
                    this.OnlyArrowIsClickable != null &&
                    this.OnlyArrowIsClickable.Equals(other.OnlyArrowIsClickable)
                ) && 
                (
                    this.OuterLabelAndArrowStyle == other.OuterLabelAndArrowStyle ||
                    this.OuterLabelAndArrowStyle != null &&
                    this.OuterLabelAndArrowStyle.Equals(other.OuterLabelAndArrowStyle)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ArrowClosed != null)
                    hash = hash * 59 + this.ArrowClosed.GetHashCode();
                if (this.ArrowColor != null)
                    hash = hash * 59 + this.ArrowColor.GetHashCode();
                if (this.ArrowLocation != null)
                    hash = hash * 59 + this.ArrowLocation.GetHashCode();
                if (this.ArrowOpen != null)
                    hash = hash * 59 + this.ArrowOpen.GetHashCode();
                if (this.ArrowSize != null)
                    hash = hash * 59 + this.ArrowSize.GetHashCode();
                if (this.ArrowStyle != null)
                    hash = hash * 59 + this.ArrowStyle.GetHashCode();
                if (this.ContainerStyle != null)
                    hash = hash * 59 + this.ContainerStyle.GetHashCode();
                if (this.LabelStyle != null)
                    hash = hash * 59 + this.LabelStyle.GetHashCode();
                if (this.OnlyArrowIsClickable != null)
                    hash = hash * 59 + this.OnlyArrowIsClickable.GetHashCode();
                if (this.OuterLabelAndArrowStyle != null)
                    hash = hash * 59 + this.OuterLabelAndArrowStyle.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
