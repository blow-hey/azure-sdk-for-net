// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Vision.ImageAnalysis
{
    /// <summary>
    /// A content entity observation in the image. A tag can be a physical object, living being, scenery, or action
    /// that appear in the image.
    /// </summary>
    public partial class DetectedTag
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

        /// <summary> Initializes a new instance of <see cref="DetectedTag"/>. </summary>
        /// <param name="confidence">
        /// A score, in the range of 0 to 1 (inclusive), representing the confidence that this entity was observed.
        /// Higher values indicating higher confidence.
        /// </param>
        /// <param name="name"> Name of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal DetectedTag(float confidence, string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Confidence = confidence;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedTag"/>. </summary>
        /// <param name="confidence">
        /// A score, in the range of 0 to 1 (inclusive), representing the confidence that this entity was observed.
        /// Higher values indicating higher confidence.
        /// </param>
        /// <param name="name"> Name of the entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DetectedTag(float confidence, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Confidence = confidence;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DetectedTag"/> for deserialization. </summary>
        internal DetectedTag()
        {
        }

        /// <summary>
        /// A score, in the range of 0 to 1 (inclusive), representing the confidence that this entity was observed.
        /// Higher values indicating higher confidence.
        /// </summary>
        public float Confidence { get; }
        /// <summary> Name of the entity. </summary>
        public string Name { get; }
    }
}
