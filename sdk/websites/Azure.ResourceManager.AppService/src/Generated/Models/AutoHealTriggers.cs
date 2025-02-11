// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Triggers for auto-heal. </summary>
    public partial class AutoHealTriggers
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

        /// <summary> Initializes a new instance of <see cref="AutoHealTriggers"/>. </summary>
        public AutoHealTriggers()
        {
            StatusCodes = new ChangeTrackingList<StatusCodesBasedTrigger>();
            SlowRequestsWithPath = new ChangeTrackingList<SlowRequestsBasedTrigger>();
            StatusCodesRange = new ChangeTrackingList<StatusCodesRangeBasedTrigger>();
        }

        /// <summary> Initializes a new instance of <see cref="AutoHealTriggers"/>. </summary>
        /// <param name="requests"> A rule based on total requests. </param>
        /// <param name="privateBytesInKB"> A rule based on private bytes. </param>
        /// <param name="statusCodes"> A rule based on status codes. </param>
        /// <param name="slowRequests"> A rule based on request execution time. </param>
        /// <param name="slowRequestsWithPath"> A rule based on multiple Slow Requests Rule with path. </param>
        /// <param name="statusCodesRange"> A rule based on status codes ranges. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutoHealTriggers(RequestsBasedTrigger requests, int? privateBytesInKB, IList<StatusCodesBasedTrigger> statusCodes, SlowRequestsBasedTrigger slowRequests, IList<SlowRequestsBasedTrigger> slowRequestsWithPath, IList<StatusCodesRangeBasedTrigger> statusCodesRange, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Requests = requests;
            PrivateBytesInKB = privateBytesInKB;
            StatusCodes = statusCodes;
            SlowRequests = slowRequests;
            SlowRequestsWithPath = slowRequestsWithPath;
            StatusCodesRange = statusCodesRange;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A rule based on total requests. </summary>
        public RequestsBasedTrigger Requests { get; set; }
        /// <summary> A rule based on private bytes. </summary>
        public int? PrivateBytesInKB { get; set; }
        /// <summary> A rule based on status codes. </summary>
        public IList<StatusCodesBasedTrigger> StatusCodes { get; }
        /// <summary> A rule based on request execution time. </summary>
        public SlowRequestsBasedTrigger SlowRequests { get; set; }
        /// <summary> A rule based on multiple Slow Requests Rule with path. </summary>
        public IList<SlowRequestsBasedTrigger> SlowRequestsWithPath { get; }
        /// <summary> A rule based on status codes ranges. </summary>
        public IList<StatusCodesRangeBasedTrigger> StatusCodesRange { get; }
    }
}
