// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MongoDBDatabaseInfo : IUtf8JsonSerializable, IJsonModel<MongoDBDatabaseInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBDatabaseInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBDatabaseInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBDatabaseInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBDatabaseInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("collections"u8);
            writer.WriteStartArray();
            foreach (var item in Collections)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("supportsSharding"u8);
            writer.WriteBooleanValue(SupportsSharding);
            writer.WritePropertyName("averageDocumentSize"u8);
            writer.WriteNumberValue(AverageDocumentSize);
            writer.WritePropertyName("dataSize"u8);
            writer.WriteNumberValue(DataSize);
            writer.WritePropertyName("documentCount"u8);
            writer.WriteNumberValue(DocumentCount);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("qualifiedName"u8);
            writer.WriteStringValue(QualifiedName);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MongoDBDatabaseInfo IJsonModel<MongoDBDatabaseInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBDatabaseInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBDatabaseInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBDatabaseInfo(document.RootElement, options);
        }

        internal static MongoDBDatabaseInfo DeserializeMongoDBDatabaseInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MongoDBCollectionInfo> collections = default;
            bool supportsSharding = default;
            long averageDocumentSize = default;
            long dataSize = default;
            long documentCount = default;
            string name = default;
            string qualifiedName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("collections"u8))
                {
                    List<MongoDBCollectionInfo> array = new List<MongoDBCollectionInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBCollectionInfo.DeserializeMongoDBCollectionInfo(item));
                    }
                    collections = array;
                    continue;
                }
                if (property.NameEquals("supportsSharding"u8))
                {
                    supportsSharding = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("averageDocumentSize"u8))
                {
                    averageDocumentSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dataSize"u8))
                {
                    dataSize = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("documentCount"u8))
                {
                    documentCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBDatabaseInfo(averageDocumentSize, dataSize, documentCount, name, qualifiedName, serializedAdditionalRawData, collections, supportsSharding);
        }

        BinaryData IPersistableModel<MongoDBDatabaseInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBDatabaseInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBDatabaseInfo)} does not support '{options.Format}' format.");
            }
        }

        MongoDBDatabaseInfo IPersistableModel<MongoDBDatabaseInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBDatabaseInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBDatabaseInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBDatabaseInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBDatabaseInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
