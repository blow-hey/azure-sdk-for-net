// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The collection of request properties. </summary>
    public partial class WebTestPropertiesRequest
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

        /// <summary> Initializes a new instance of <see cref="WebTestPropertiesRequest"/>. </summary>
        public WebTestPropertiesRequest()
        {
            Headers = new ChangeTrackingList<HeaderField>();
        }

        /// <summary> Initializes a new instance of <see cref="WebTestPropertiesRequest"/>. </summary>
        /// <param name="requestUri"> Url location to test. </param>
        /// <param name="headers"> List of headers and their values to add to the WebTest call. </param>
        /// <param name="httpVerb"> Http verb to use for this web test. </param>
        /// <param name="requestBody"> Base64 encoded string body to send with this web test. </param>
        /// <param name="parseDependentRequests"> Parse Dependent request for this WebTest. </param>
        /// <param name="followRedirects"> Follow redirects for this web test. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebTestPropertiesRequest(Uri requestUri, IList<HeaderField> headers, string httpVerb, string requestBody, bool? parseDependentRequests, bool? followRedirects, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequestUri = requestUri;
            Headers = headers;
            HttpVerb = httpVerb;
            RequestBody = requestBody;
            ParseDependentRequests = parseDependentRequests;
            FollowRedirects = followRedirects;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Url location to test. </summary>
        public Uri RequestUri { get; set; }
        /// <summary> List of headers and their values to add to the WebTest call. </summary>
        public IList<HeaderField> Headers { get; }
        /// <summary> Http verb to use for this web test. </summary>
        public string HttpVerb { get; set; }
        /// <summary> Base64 encoded string body to send with this web test. </summary>
        public string RequestBody { get; set; }
        /// <summary> Parse Dependent request for this WebTest. </summary>
        public bool? ParseDependentRequests { get; set; }
        /// <summary> Follow redirects for this web test. </summary>
        public bool? FollowRedirects { get; set; }
    }
}
