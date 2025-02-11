// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryApplicationVersionPublishingProfile : IUtf8JsonSerializable, IJsonModel<GalleryApplicationVersionPublishingProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GalleryApplicationVersionPublishingProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GalleryApplicationVersionPublishingProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryApplicationVersionPublishingProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("source"u8);
            writer.WriteObjectValue(Source);
            if (Optional.IsDefined(ManageActions))
            {
                writer.WritePropertyName("manageActions"u8);
                writer.WriteObjectValue(ManageActions);
            }
            if (Optional.IsDefined(Settings))
            {
                writer.WritePropertyName("settings"u8);
                writer.WriteObjectValue(Settings);
            }
            if (Optional.IsCollectionDefined(AdvancedSettings))
            {
                writer.WritePropertyName("advancedSettings"u8);
                writer.WriteStartObject();
                foreach (var item in AdvancedSettings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(EnableHealthCheck))
            {
                writer.WritePropertyName("enableHealthCheck"u8);
                writer.WriteBooleanValue(EnableHealthCheck.Value);
            }
            if (Optional.IsCollectionDefined(CustomActions))
            {
                writer.WritePropertyName("customActions"u8);
                writer.WriteStartArray();
                foreach (var item in CustomActions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TargetRegions))
            {
                writer.WritePropertyName("targetRegions"u8);
                writer.WriteStartArray();
                foreach (var item in TargetRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReplicaCount))
            {
                writer.WritePropertyName("replicaCount"u8);
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (Optional.IsDefined(IsExcludedFromLatest))
            {
                writer.WritePropertyName("excludeFromLatest"u8);
                writer.WriteBooleanValue(IsExcludedFromLatest.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("publishedDate"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (Optional.IsDefined(EndOfLifeOn))
            {
                writer.WritePropertyName("endOfLifeDate"u8);
                writer.WriteStringValue(EndOfLifeOn.Value, "O");
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType"u8);
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationMode))
            {
                writer.WritePropertyName("replicationMode"u8);
                writer.WriteStringValue(ReplicationMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(TargetExtendedLocations))
            {
                writer.WritePropertyName("targetExtendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in TargetExtendedLocations)
                {
                    writer.WriteObjectValue(item);
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

        GalleryApplicationVersionPublishingProfile IJsonModel<GalleryApplicationVersionPublishingProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GalleryApplicationVersionPublishingProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGalleryApplicationVersionPublishingProfile(document.RootElement, options);
        }

        internal static GalleryApplicationVersionPublishingProfile DeserializeGalleryApplicationVersionPublishingProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UserArtifactSource source = default;
            Optional<UserArtifactManagement> manageActions = default;
            Optional<UserArtifactSettings> settings = default;
            Optional<IDictionary<string, string>> advancedSettings = default;
            Optional<bool> enableHealthCheck = default;
            Optional<IList<GalleryApplicationCustomAction>> customActions = default;
            Optional<IList<TargetRegion>> targetRegions = default;
            Optional<int> replicaCount = default;
            Optional<bool> excludeFromLatest = default;
            Optional<DateTimeOffset> publishedDate = default;
            Optional<DateTimeOffset> endOfLifeDate = default;
            Optional<ImageStorageAccountType> storageAccountType = default;
            Optional<GalleryReplicationMode> replicationMode = default;
            Optional<IList<GalleryTargetExtendedLocation>> targetExtendedLocations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    source = UserArtifactSource.DeserializeUserArtifactSource(property.Value);
                    continue;
                }
                if (property.NameEquals("manageActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    manageActions = UserArtifactManagement.DeserializeUserArtifactManagement(property.Value);
                    continue;
                }
                if (property.NameEquals("settings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    settings = UserArtifactSettings.DeserializeUserArtifactSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("advancedSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    advancedSettings = dictionary;
                    continue;
                }
                if (property.NameEquals("enableHealthCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableHealthCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryApplicationCustomAction> array = new List<GalleryApplicationCustomAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryApplicationCustomAction.DeserializeGalleryApplicationCustomAction(item));
                    }
                    customActions = array;
                    continue;
                }
                if (property.NameEquals("targetRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetRegion.DeserializeTargetRegion(item));
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new ImageStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationMode = new GalleryReplicationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetExtendedLocations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GalleryTargetExtendedLocation> array = new List<GalleryTargetExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GalleryTargetExtendedLocation.DeserializeGalleryTargetExtendedLocation(item));
                    }
                    targetExtendedLocations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GalleryApplicationVersionPublishingProfile(Optional.ToList(targetRegions), Optional.ToNullable(replicaCount), Optional.ToNullable(excludeFromLatest), Optional.ToNullable(publishedDate), Optional.ToNullable(endOfLifeDate), Optional.ToNullable(storageAccountType), Optional.ToNullable(replicationMode), Optional.ToList(targetExtendedLocations), serializedAdditionalRawData, source, manageActions.Value, settings.Value, Optional.ToDictionary(advancedSettings), Optional.ToNullable(enableHealthCheck), Optional.ToList(customActions));
        }

        BinaryData IPersistableModel<GalleryApplicationVersionPublishingProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GalleryApplicationVersionPublishingProfile)} does not support '{options.Format}' format.");
            }
        }

        GalleryApplicationVersionPublishingProfile IPersistableModel<GalleryApplicationVersionPublishingProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GalleryApplicationVersionPublishingProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGalleryApplicationVersionPublishingProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GalleryApplicationVersionPublishingProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GalleryApplicationVersionPublishingProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
