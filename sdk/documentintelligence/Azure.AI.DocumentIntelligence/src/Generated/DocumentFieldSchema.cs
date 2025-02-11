// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Description of the field semantic schema using a JSON Schema style syntax. </summary>
    public partial class DocumentFieldSchema
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

        /// <summary> Initializes a new instance of <see cref="DocumentFieldSchema"/>. </summary>
        /// <param name="type"> Semantic data type of the field value. </param>
        internal DocumentFieldSchema(DocumentFieldType type)
        {
            Type = type;
            Properties = new ChangeTrackingDictionary<string, DocumentFieldSchema>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFieldSchema"/>. </summary>
        /// <param name="type"> Semantic data type of the field value. </param>
        /// <param name="description"> Field description. </param>
        /// <param name="example"> Example field content. </param>
        /// <param name="items"> Field type schema of each array element. </param>
        /// <param name="properties"> Named sub-fields of the object field. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentFieldSchema(DocumentFieldType type, string description, string example, DocumentFieldSchema items, IReadOnlyDictionary<string, DocumentFieldSchema> properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Type = type;
            Description = description;
            Example = example;
            Items = items;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFieldSchema"/> for deserialization. </summary>
        internal DocumentFieldSchema()
        {
        }

        /// <summary> Semantic data type of the field value. </summary>
        public DocumentFieldType Type { get; }
        /// <summary> Field description. </summary>
        public string Description { get; }
        /// <summary> Example field content. </summary>
        public string Example { get; }
        /// <summary> Field type schema of each array element. </summary>
        public DocumentFieldSchema Items { get; }
        /// <summary> Named sub-fields of the object field. </summary>
        public IReadOnlyDictionary<string, DocumentFieldSchema> Properties { get; }
    }
}
