// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Properties of a configure alert request. </summary>
    public partial class SiteRecoveryConfigureAlertProperties
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

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryConfigureAlertProperties"/>. </summary>
        public SiteRecoveryConfigureAlertProperties()
        {
            CustomEmailAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryConfigureAlertProperties"/>. </summary>
        /// <param name="sendToOwners"> A value indicating whether to send email to subscription administrator. </param>
        /// <param name="customEmailAddresses"> The custom email address for sending emails. </param>
        /// <param name="locale"> The locale for the email notification. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryConfigureAlertProperties(string sendToOwners, IList<string> customEmailAddresses, string locale, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SendToOwners = sendToOwners;
            CustomEmailAddresses = customEmailAddresses;
            Locale = locale;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A value indicating whether to send email to subscription administrator. </summary>
        public string SendToOwners { get; set; }
        /// <summary> The custom email address for sending emails. </summary>
        public IList<string> CustomEmailAddresses { get; }
        /// <summary> The locale for the email notification. </summary>
        public string Locale { get; set; }
    }
}
