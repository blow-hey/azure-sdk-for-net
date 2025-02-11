// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricInternalNetworkPatch : IUtf8JsonSerializable, IJsonModel<NetworkFabricInternalNetworkPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricInternalNetworkPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFabricInternalNetworkPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(Mtu))
            {
                writer.WritePropertyName("mtu"u8);
                writer.WriteNumberValue(Mtu.Value);
            }
            if (Optional.IsCollectionDefined(ConnectedIPv4Subnets))
            {
                writer.WritePropertyName("connectedIPv4Subnets"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedIPv4Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ConnectedIPv6Subnets))
            {
                writer.WritePropertyName("connectedIPv6Subnets"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectedIPv6Subnets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ImportRoutePolicyId))
            {
                writer.WritePropertyName("importRoutePolicyId"u8);
                writer.WriteStringValue(ImportRoutePolicyId);
            }
            if (Optional.IsDefined(ExportRoutePolicyId))
            {
                writer.WritePropertyName("exportRoutePolicyId"u8);
                writer.WriteStringValue(ExportRoutePolicyId);
            }
            if (Optional.IsDefined(ImportRoutePolicy))
            {
                writer.WritePropertyName("importRoutePolicy"u8);
                writer.WriteObjectValue(ImportRoutePolicy);
            }
            if (Optional.IsDefined(ExportRoutePolicy))
            {
                writer.WritePropertyName("exportRoutePolicy"u8);
                writer.WriteObjectValue(ExportRoutePolicy);
            }
            if (Optional.IsDefined(IngressAclId))
            {
                writer.WritePropertyName("ingressAclId"u8);
                writer.WriteStringValue(IngressAclId);
            }
            if (Optional.IsDefined(EgressAclId))
            {
                writer.WritePropertyName("egressAclId"u8);
                writer.WriteStringValue(EgressAclId);
            }
            if (Optional.IsDefined(IsMonitoringEnabled))
            {
                writer.WritePropertyName("isMonitoringEnabled"u8);
                writer.WriteStringValue(IsMonitoringEnabled.Value.ToString());
            }
            if (Optional.IsDefined(BgpConfiguration))
            {
                writer.WritePropertyName("bgpConfiguration"u8);
                writer.WriteObjectValue(BgpConfiguration);
            }
            if (Optional.IsDefined(StaticRouteConfiguration))
            {
                writer.WritePropertyName("staticRouteConfiguration"u8);
                writer.WriteObjectValue(StaticRouteConfiguration);
            }
            writer.WriteEndObject();
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

        NetworkFabricInternalNetworkPatch IJsonModel<NetworkFabricInternalNetworkPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricInternalNetworkPatch(document.RootElement, options);
        }

        internal static NetworkFabricInternalNetworkPatch DeserializeNetworkFabricInternalNetworkPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> annotation = default;
            Optional<int> mtu = default;
            Optional<IList<ConnectedSubnet>> connectedIPv4Subnets = default;
            Optional<IList<ConnectedSubnet>> connectedIPv6Subnets = default;
            Optional<ResourceIdentifier> importRoutePolicyId = default;
            Optional<ResourceIdentifier> exportRoutePolicyId = default;
            Optional<ImportRoutePolicy> importRoutePolicy = default;
            Optional<ExportRoutePolicy> exportRoutePolicy = default;
            Optional<ResourceIdentifier> ingressAclId = default;
            Optional<ResourceIdentifier> egressAclId = default;
            Optional<IsMonitoringEnabled> isMonitoringEnabled = default;
            Optional<BgpConfiguration> bgpConfiguration = default;
            Optional<StaticRouteConfiguration> staticRouteConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("mtu"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mtu = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectedIPv4Subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectedSubnet> array = new List<ConnectedSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedSubnet.DeserializeConnectedSubnet(item));
                            }
                            connectedIPv4Subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("connectedIPv6Subnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ConnectedSubnet> array = new List<ConnectedSubnet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ConnectedSubnet.DeserializeConnectedSubnet(item));
                            }
                            connectedIPv6Subnets = array;
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicyId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("importRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            importRoutePolicy = ImportRoutePolicy.DeserializeImportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("exportRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            exportRoutePolicy = ExportRoutePolicy.DeserializeExportRoutePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ingressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("egressAclId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressAclId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isMonitoringEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isMonitoringEnabled = new IsMonitoringEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("bgpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bgpConfiguration = BgpConfiguration.DeserializeBgpConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("staticRouteConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            staticRouteConfiguration = StaticRouteConfiguration.DeserializeStaticRouteConfiguration(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkFabricInternalNetworkPatch(annotation.Value, Optional.ToNullable(mtu), Optional.ToList(connectedIPv4Subnets), Optional.ToList(connectedIPv6Subnets), importRoutePolicyId.Value, exportRoutePolicyId.Value, importRoutePolicy.Value, exportRoutePolicy.Value, ingressAclId.Value, egressAclId.Value, Optional.ToNullable(isMonitoringEnabled), bgpConfiguration.Value, staticRouteConfiguration.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricInternalNetworkPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkPatch)} does not support '{options.Format}' format.");
            }
        }

        NetworkFabricInternalNetworkPatch IPersistableModel<NetworkFabricInternalNetworkPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricInternalNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFabricInternalNetworkPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricInternalNetworkPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFabricInternalNetworkPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
