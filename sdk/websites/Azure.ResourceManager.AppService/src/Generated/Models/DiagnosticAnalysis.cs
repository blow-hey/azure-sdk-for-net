// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class representing a diagnostic analysis done on an application. </summary>
    public partial class DiagnosticAnalysis : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiagnosticAnalysis"/>. </summary>
        public DiagnosticAnalysis()
        {
            AbnormalTimePeriods = new ChangeTrackingList<AbnormalTimePeriod>();
            Payload = new ChangeTrackingList<AnalysisDetectorEvidences>();
            NonCorrelatedDetectors = new ChangeTrackingList<DetectorDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticAnalysis"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Start time of the period. </param>
        /// <param name="endOn"> End time of the period. </param>
        /// <param name="abnormalTimePeriods"> List of time periods. </param>
        /// <param name="payload"> Data by each detector. </param>
        /// <param name="nonCorrelatedDetectors"> Data by each detector for detectors that did not corelate. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticAnalysis(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? startOn, DateTimeOffset? endOn, IList<AbnormalTimePeriod> abnormalTimePeriods, IList<AnalysisDetectorEvidences> payload, IList<DetectorDefinition> nonCorrelatedDetectors, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StartOn = startOn;
            EndOn = endOn;
            AbnormalTimePeriods = abnormalTimePeriods;
            Payload = payload;
            NonCorrelatedDetectors = nonCorrelatedDetectors;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Start time of the period. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> End time of the period. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> List of time periods. </summary>
        public IList<AbnormalTimePeriod> AbnormalTimePeriods { get; }
        /// <summary> Data by each detector. </summary>
        public IList<AnalysisDetectorEvidences> Payload { get; }
        /// <summary> Data by each detector for detectors that did not corelate. </summary>
        public IList<DetectorDefinition> NonCorrelatedDetectors { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
