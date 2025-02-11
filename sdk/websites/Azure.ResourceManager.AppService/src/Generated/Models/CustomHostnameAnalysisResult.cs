// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Custom domain analysis. </summary>
    public partial class CustomHostnameAnalysisResult : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="CustomHostnameAnalysisResult"/>. </summary>
        public CustomHostnameAnalysisResult()
        {
            CNameRecords = new ChangeTrackingList<string>();
            TxtRecords = new ChangeTrackingList<string>();
            ARecords = new ChangeTrackingList<string>();
            AlternateCNameRecords = new ChangeTrackingList<string>();
            AlternateTxtRecords = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="CustomHostnameAnalysisResult"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isHostnameAlreadyVerified"> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="customDomainVerificationTest"> DNS verification test result. </param>
        /// <param name="customDomainVerificationFailureInfo"> Raw failure information if DNS verification fails. </param>
        /// <param name="hasConflictOnScaleUnit"> &lt;code&gt;true&lt;/code&gt; if there is a conflict on a scale unit; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="hasConflictAcrossSubscription"> &lt;code&gt;true&lt;/code&gt; if there is a conflict across subscriptions; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="conflictingAppResourceId"> Name of the conflicting app on scale unit if it's within the same subscription. </param>
        /// <param name="cNameRecords"> CName records controller can see for this hostname. </param>
        /// <param name="txtRecords"> TXT records controller can see for this hostname. </param>
        /// <param name="aRecords"> A records controller can see for this hostname. </param>
        /// <param name="alternateCNameRecords"> Alternate CName records controller can see for this hostname. </param>
        /// <param name="alternateTxtRecords"> Alternate TXT records controller can see for this hostname. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomHostnameAnalysisResult(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? isHostnameAlreadyVerified, DnsVerificationTestResult? customDomainVerificationTest, ResponseError customDomainVerificationFailureInfo, bool? hasConflictOnScaleUnit, bool? hasConflictAcrossSubscription, string conflictingAppResourceId, IList<string> cNameRecords, IList<string> txtRecords, IList<string> aRecords, IList<string> alternateCNameRecords, IList<string> alternateTxtRecords, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            IsHostnameAlreadyVerified = isHostnameAlreadyVerified;
            CustomDomainVerificationTest = customDomainVerificationTest;
            CustomDomainVerificationFailureInfo = customDomainVerificationFailureInfo;
            HasConflictOnScaleUnit = hasConflictOnScaleUnit;
            HasConflictAcrossSubscription = hasConflictAcrossSubscription;
            ConflictingAppResourceId = conflictingAppResourceId;
            CNameRecords = cNameRecords;
            TxtRecords = txtRecords;
            ARecords = aRecords;
            AlternateCNameRecords = alternateCNameRecords;
            AlternateTxtRecords = alternateTxtRecords;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;true&lt;/code&gt; if hostname is already verified; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsHostnameAlreadyVerified { get; }
        /// <summary> DNS verification test result. </summary>
        public DnsVerificationTestResult? CustomDomainVerificationTest { get; }
        /// <summary> Raw failure information if DNS verification fails. </summary>
        public ResponseError CustomDomainVerificationFailureInfo { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict on a scale unit; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HasConflictOnScaleUnit { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if there is a conflict across subscriptions; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HasConflictAcrossSubscription { get; }
        /// <summary> Name of the conflicting app on scale unit if it's within the same subscription. </summary>
        public string ConflictingAppResourceId { get; }
        /// <summary> CName records controller can see for this hostname. </summary>
        public IList<string> CNameRecords { get; }
        /// <summary> TXT records controller can see for this hostname. </summary>
        public IList<string> TxtRecords { get; }
        /// <summary> A records controller can see for this hostname. </summary>
        public IList<string> ARecords { get; }
        /// <summary> Alternate CName records controller can see for this hostname. </summary>
        public IList<string> AlternateCNameRecords { get; }
        /// <summary> Alternate TXT records controller can see for this hostname. </summary>
        public IList<string> AlternateTxtRecords { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
