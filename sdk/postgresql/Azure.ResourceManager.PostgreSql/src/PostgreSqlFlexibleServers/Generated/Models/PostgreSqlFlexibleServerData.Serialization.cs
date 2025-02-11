// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    public partial class PostgreSqlFlexibleServerData : IUtf8JsonSerializable, IJsonModel<PostgreSqlFlexibleServerData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostgreSqlFlexibleServerData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostgreSqlFlexibleServerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AdministratorLogin))
            {
                writer.WritePropertyName("administratorLogin"u8);
                writer.WriteStringValue(AdministratorLogin);
            }
            if (Optional.IsDefined(AdministratorLoginPassword))
            {
                writer.WritePropertyName("administratorLoginPassword"u8);
                writer.WriteStringValue(AdministratorLoginPassword);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(MinorVersion))
            {
                writer.WritePropertyName("minorVersion"u8);
                writer.WriteStringValue(MinorVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FullyQualifiedDomainName))
            {
                writer.WritePropertyName("fullyQualifiedDomainName"u8);
                writer.WriteStringValue(FullyQualifiedDomainName);
            }
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteObjectValue(Storage);
            }
            if (Optional.IsDefined(AuthConfig))
            {
                writer.WritePropertyName("authConfig"u8);
                writer.WriteObjectValue(AuthConfig);
            }
            if (Optional.IsDefined(DataEncryption))
            {
                writer.WritePropertyName("dataEncryption"u8);
                writer.WriteObjectValue(DataEncryption);
            }
            if (Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup"u8);
                writer.WriteObjectValue(Backup);
            }
            if (Optional.IsDefined(Network))
            {
                writer.WritePropertyName("network"u8);
                writer.WriteObjectValue(Network);
            }
            if (Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability"u8);
                writer.WriteObjectValue(HighAvailability);
            }
            if (Optional.IsDefined(MaintenanceWindow))
            {
                writer.WritePropertyName("maintenanceWindow"u8);
                writer.WriteObjectValue(MaintenanceWindow);
            }
            if (Optional.IsDefined(SourceServerResourceId))
            {
                writer.WritePropertyName("sourceServerResourceId"u8);
                writer.WriteStringValue(SourceServerResourceId);
            }
            if (Optional.IsDefined(PointInTimeUtc))
            {
                writer.WritePropertyName("pointInTimeUTC"u8);
                writer.WriteStringValue(PointInTimeUtc.Value, "O");
            }
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Optional.IsDefined(ReplicationRole))
            {
                writer.WritePropertyName("replicationRole"u8);
                writer.WriteStringValue(ReplicationRole.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ReplicaCapacity))
            {
                writer.WritePropertyName("replicaCapacity"u8);
                writer.WriteNumberValue(ReplicaCapacity.Value);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
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

        PostgreSqlFlexibleServerData IJsonModel<PostgreSqlFlexibleServerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerData(document.RootElement, options);
        }

        internal static PostgreSqlFlexibleServerData DeserializePostgreSqlFlexibleServerData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PostgreSqlFlexibleServerSku> sku = default;
            Optional<PostgreSqlFlexibleServerUserAssignedIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> administratorLogin = default;
            Optional<string> administratorLoginPassword = default;
            Optional<PostgreSqlFlexibleServerVersion> version = default;
            Optional<string> minorVersion = default;
            Optional<PostgreSqlFlexibleServerState> state = default;
            Optional<string> fullyQualifiedDomainName = default;
            Optional<PostgreSqlFlexibleServerStorage> storage = default;
            Optional<PostgreSqlFlexibleServerAuthConfig> authConfig = default;
            Optional<PostgreSqlFlexibleServerDataEncryption> dataEncryption = default;
            Optional<PostgreSqlFlexibleServerBackupProperties> backup = default;
            Optional<PostgreSqlFlexibleServerNetwork> network = default;
            Optional<PostgreSqlFlexibleServerHighAvailability> highAvailability = default;
            Optional<PostgreSqlFlexibleServerMaintenanceWindow> maintenanceWindow = default;
            Optional<ResourceIdentifier> sourceServerResourceId = default;
            Optional<DateTimeOffset> pointInTimeUTC = default;
            Optional<string> availabilityZone = default;
            Optional<PostgreSqlFlexibleServerReplicationRole> replicationRole = default;
            Optional<int> replicaCapacity = default;
            Optional<PostgreSqlFlexibleServerCreateMode> createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = PostgreSqlFlexibleServerSku.DeserializePostgreSqlFlexibleServerSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = PostgreSqlFlexibleServerUserAssignedIdentity.DeserializePostgreSqlFlexibleServerUserAssignedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("administratorLogin"u8))
                        {
                            administratorLogin = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("administratorLoginPassword"u8))
                        {
                            administratorLoginPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = new PostgreSqlFlexibleServerVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minorVersion"u8))
                        {
                            minorVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new PostgreSqlFlexibleServerState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fullyQualifiedDomainName"u8))
                        {
                            fullyQualifiedDomainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storage"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storage = PostgreSqlFlexibleServerStorage.DeserializePostgreSqlFlexibleServerStorage(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("authConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authConfig = PostgreSqlFlexibleServerAuthConfig.DeserializePostgreSqlFlexibleServerAuthConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataEncryption = PostgreSqlFlexibleServerDataEncryption.DeserializePostgreSqlFlexibleServerDataEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backup = PostgreSqlFlexibleServerBackupProperties.DeserializePostgreSqlFlexibleServerBackupProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("network"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            network = PostgreSqlFlexibleServerNetwork.DeserializePostgreSqlFlexibleServerNetwork(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("highAvailability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            highAvailability = PostgreSqlFlexibleServerHighAvailability.DeserializePostgreSqlFlexibleServerHighAvailability(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("maintenanceWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceWindow = PostgreSqlFlexibleServerMaintenanceWindow.DeserializePostgreSqlFlexibleServerMaintenanceWindow(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceServerResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceServerResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("pointInTimeUTC"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pointInTimeUTC = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("availabilityZone"u8))
                        {
                            availabilityZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("replicationRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationRole = new PostgreSqlFlexibleServerReplicationRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("replicaCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicaCapacity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new PostgreSqlFlexibleServerCreateMode(property0.Value.GetString());
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
            return new PostgreSqlFlexibleServerData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku.Value, identity.Value, administratorLogin.Value, administratorLoginPassword.Value, Optional.ToNullable(version), minorVersion.Value, Optional.ToNullable(state), fullyQualifiedDomainName.Value, storage.Value, authConfig.Value, dataEncryption.Value, backup.Value, network.Value, highAvailability.Value, maintenanceWindow.Value, sourceServerResourceId.Value, Optional.ToNullable(pointInTimeUTC), availabilityZone.Value, Optional.ToNullable(replicationRole), Optional.ToNullable(replicaCapacity), Optional.ToNullable(createMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostgreSqlFlexibleServerData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerData)} does not support '{options.Format}' format.");
            }
        }

        PostgreSqlFlexibleServerData IPersistableModel<PostgreSqlFlexibleServerData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostgreSqlFlexibleServerData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostgreSqlFlexibleServerData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostgreSqlFlexibleServerData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostgreSqlFlexibleServerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
