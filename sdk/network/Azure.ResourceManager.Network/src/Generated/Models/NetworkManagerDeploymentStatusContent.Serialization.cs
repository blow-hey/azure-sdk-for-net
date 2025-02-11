// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkManagerDeploymentStatusContent : IUtf8JsonSerializable, IJsonModel<NetworkManagerDeploymentStatusContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkManagerDeploymentStatusContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkManagerDeploymentStatusContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Regions))
            {
                writer.WritePropertyName("regions"u8);
                writer.WriteStartArray();
                foreach (var item in Regions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DeploymentTypes))
            {
                writer.WritePropertyName("deploymentTypes"u8);
                writer.WriteStartArray();
                foreach (var item in DeploymentTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SkipToken))
            {
                writer.WritePropertyName("skipToken"u8);
                writer.WriteStringValue(SkipToken);
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

        NetworkManagerDeploymentStatusContent IJsonModel<NetworkManagerDeploymentStatusContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkManagerDeploymentStatusContent(document.RootElement, options);
        }

        internal static NetworkManagerDeploymentStatusContent DeserializeNetworkManagerDeploymentStatusContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> regions = default;
            Optional<IList<NetworkConfigurationDeploymentType>> deploymentTypes = default;
            Optional<string> skipToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("regions"u8))
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
                    regions = array;
                    continue;
                }
                if (property.NameEquals("deploymentTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationDeploymentType> array = new List<NetworkConfigurationDeploymentType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new NetworkConfigurationDeploymentType(item.GetString()));
                    }
                    deploymentTypes = array;
                    continue;
                }
                if (property.NameEquals("skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkManagerDeploymentStatusContent(Optional.ToList(regions), Optional.ToList(deploymentTypes), skipToken.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkManagerDeploymentStatusContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusContent)} does not support '{options.Format}' format.");
            }
        }

        NetworkManagerDeploymentStatusContent IPersistableModel<NetworkManagerDeploymentStatusContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkManagerDeploymentStatusContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkManagerDeploymentStatusContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkManagerDeploymentStatusContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkManagerDeploymentStatusContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
