// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class DiagnoseVirtualNetworkResult : IUtf8JsonSerializable, IJsonModel<DiagnoseVirtualNetworkResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnoseVirtualNetworkResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiagnoseVirtualNetworkResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnoseVirtualNetworkResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnoseVirtualNetworkResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Findings))
            {
                writer.WritePropertyName("findings"u8);
                writer.WriteStartArray();
                foreach (var item in Findings)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        DiagnoseVirtualNetworkResult IJsonModel<DiagnoseVirtualNetworkResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnoseVirtualNetworkResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiagnoseVirtualNetworkResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnoseVirtualNetworkResult(document.RootElement, options);
        }

        internal static DiagnoseVirtualNetworkResult DeserializeDiagnoseVirtualNetworkResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<string>> findings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("findings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    findings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiagnoseVirtualNetworkResult(Optional.ToList(findings), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnoseVirtualNetworkResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnoseVirtualNetworkResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiagnoseVirtualNetworkResult)} does not support '{options.Format}' format.");
            }
        }

        DiagnoseVirtualNetworkResult IPersistableModel<DiagnoseVirtualNetworkResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiagnoseVirtualNetworkResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiagnoseVirtualNetworkResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiagnoseVirtualNetworkResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiagnoseVirtualNetworkResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
