// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    [PersistableModelProxy(typeof(UnknownGranularCopyLogDetails))]
    public partial class GranularCopyLogDetails : IUtf8JsonSerializable, IJsonModel<GranularCopyLogDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GranularCopyLogDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GranularCopyLogDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GranularCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GranularCopyLogDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("copyLogDetailsType"u8);
            writer.WriteStringValue(CopyLogDetailsType.ToSerialString());
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

        GranularCopyLogDetails IJsonModel<GranularCopyLogDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GranularCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GranularCopyLogDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGranularCopyLogDetails(document.RootElement, options);
        }

        internal static GranularCopyLogDetails DeserializeGranularCopyLogDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("copyLogDetailsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DataBoxCustomerDisk": return DataBoxDiskGranularCopyLogDetails.DeserializeDataBoxDiskGranularCopyLogDetails(element);
                }
            }
            return UnknownGranularCopyLogDetails.DeserializeUnknownGranularCopyLogDetails(element);
        }

        BinaryData IPersistableModel<GranularCopyLogDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GranularCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GranularCopyLogDetails)} does not support '{options.Format}' format.");
            }
        }

        GranularCopyLogDetails IPersistableModel<GranularCopyLogDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GranularCopyLogDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGranularCopyLogDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GranularCopyLogDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GranularCopyLogDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
