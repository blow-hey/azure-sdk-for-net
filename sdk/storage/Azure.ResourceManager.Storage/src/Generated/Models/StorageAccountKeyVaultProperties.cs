// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Properties of key vault. </summary>
    public partial class StorageAccountKeyVaultProperties
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

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyVaultProperties"/>. </summary>
        public StorageAccountKeyVaultProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountKeyVaultProperties"/>. </summary>
        /// <param name="keyName"> The name of KeyVault key. </param>
        /// <param name="keyVersion"> The version of KeyVault key. </param>
        /// <param name="keyVaultUri"> The Uri of KeyVault. </param>
        /// <param name="currentVersionedKeyIdentifier"> The object identifier of the current versioned Key Vault Key in use. </param>
        /// <param name="lastKeyRotationTimestamp"> Timestamp of last rotation of the Key Vault Key. </param>
        /// <param name="currentVersionedKeyExpirationTimestamp"> This is a read only property that represents the expiration time of the current version of the customer managed key used for encryption. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountKeyVaultProperties(string keyName, string keyVersion, Uri keyVaultUri, string currentVersionedKeyIdentifier, DateTimeOffset? lastKeyRotationTimestamp, DateTimeOffset? currentVersionedKeyExpirationTimestamp, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyName = keyName;
            KeyVersion = keyVersion;
            KeyVaultUri = keyVaultUri;
            CurrentVersionedKeyIdentifier = currentVersionedKeyIdentifier;
            LastKeyRotationTimestamp = lastKeyRotationTimestamp;
            CurrentVersionedKeyExpirationTimestamp = currentVersionedKeyExpirationTimestamp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of KeyVault key. </summary>
        public string KeyName { get; set; }
        /// <summary> The version of KeyVault key. </summary>
        public string KeyVersion { get; set; }
        /// <summary> The Uri of KeyVault. </summary>
        public Uri KeyVaultUri { get; set; }
        /// <summary> The object identifier of the current versioned Key Vault Key in use. </summary>
        public string CurrentVersionedKeyIdentifier { get; }
        /// <summary> Timestamp of last rotation of the Key Vault Key. </summary>
        public DateTimeOffset? LastKeyRotationTimestamp { get; }
        /// <summary> This is a read only property that represents the expiration time of the current version of the customer managed key used for encryption. </summary>
        public DateTimeOffset? CurrentVersionedKeyExpirationTimestamp { get; }
    }
}
