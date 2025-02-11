// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> General information regarding the current resource. </summary>
    public partial class ResourceDetails
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

        /// <summary> Initializes a new instance of <see cref="ResourceDetails"/>. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <param name="customNeuralDocumentModelBuilds"> Quota used, limit, and next reset date/time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customDocumentModels"/> or <paramref name="customNeuralDocumentModelBuilds"/> is null. </exception>
        internal ResourceDetails(CustomDocumentModelsDetails customDocumentModels, QuotaDetails customNeuralDocumentModelBuilds)
        {
            Argument.AssertNotNull(customDocumentModels, nameof(customDocumentModels));
            Argument.AssertNotNull(customNeuralDocumentModelBuilds, nameof(customNeuralDocumentModelBuilds));

            CustomDocumentModels = customDocumentModels;
            CustomNeuralDocumentModelBuilds = customNeuralDocumentModelBuilds;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceDetails"/>. </summary>
        /// <param name="customDocumentModels"> Details regarding custom document models. </param>
        /// <param name="customNeuralDocumentModelBuilds"> Quota used, limit, and next reset date/time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceDetails(CustomDocumentModelsDetails customDocumentModels, QuotaDetails customNeuralDocumentModelBuilds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CustomDocumentModels = customDocumentModels;
            CustomNeuralDocumentModelBuilds = customNeuralDocumentModelBuilds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceDetails"/> for deserialization. </summary>
        internal ResourceDetails()
        {
        }

        /// <summary> Details regarding custom document models. </summary>
        public CustomDocumentModelsDetails CustomDocumentModels { get; }
        /// <summary> Quota used, limit, and next reset date/time. </summary>
        public QuotaDetails CustomNeuralDocumentModelBuilds { get; }
    }
}
