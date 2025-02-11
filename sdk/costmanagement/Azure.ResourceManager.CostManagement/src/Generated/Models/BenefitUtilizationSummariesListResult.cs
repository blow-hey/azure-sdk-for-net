// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> List of benefit utilization summaries. </summary>
    internal partial class BenefitUtilizationSummariesListResult
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

        /// <summary> Initializes a new instance of <see cref="BenefitUtilizationSummariesListResult"/>. </summary>
        internal BenefitUtilizationSummariesListResult()
        {
            Value = new ChangeTrackingList<BenefitUtilizationSummary>();
        }

        /// <summary> Initializes a new instance of <see cref="BenefitUtilizationSummariesListResult"/>. </summary>
        /// <param name="value">
        /// The list of benefit utilization summaries.
        /// Please note <see cref="BenefitUtilizationSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="IncludedQuantityUtilizationSummary"/> and <see cref="SavingsPlanUtilizationSummary"/>.
        /// </param>
        /// <param name="nextLink"> The link (URL) to the next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BenefitUtilizationSummariesListResult(IReadOnlyList<BenefitUtilizationSummary> value, Uri nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// The list of benefit utilization summaries.
        /// Please note <see cref="BenefitUtilizationSummary"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="IncludedQuantityUtilizationSummary"/> and <see cref="SavingsPlanUtilizationSummary"/>.
        /// </summary>
        public IReadOnlyList<BenefitUtilizationSummary> Value { get; }
        /// <summary> The link (URL) to the next page of results. </summary>
        public Uri NextLink { get; }
    }
}
