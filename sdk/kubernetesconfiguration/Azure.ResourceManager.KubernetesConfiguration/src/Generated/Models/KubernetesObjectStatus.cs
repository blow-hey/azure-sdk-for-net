// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Statuses of objects deployed by the user-specified kustomizations from the git repository. </summary>
    public partial class KubernetesObjectStatus
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

        /// <summary> Initializes a new instance of <see cref="KubernetesObjectStatus"/>. </summary>
        internal KubernetesObjectStatus()
        {
            StatusConditions = new ChangeTrackingList<KubernetesObjectStatusCondition>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesObjectStatus"/>. </summary>
        /// <param name="name"> Name of the applied object. </param>
        /// <param name="namespace"> Namespace of the applied object. </param>
        /// <param name="kind"> Kind of the applied object. </param>
        /// <param name="complianceState"> Compliance state of the applied object showing whether the applied object has come into a ready state on the cluster. </param>
        /// <param name="appliedBy"> Object reference to the Kustomization that applied this object. </param>
        /// <param name="statusConditions"> List of Kubernetes object status conditions present on the cluster. </param>
        /// <param name="helmReleaseProperties"> Additional properties that are provided from objects of the HelmRelease kind. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KubernetesObjectStatus(string name, string @namespace, string kind, KubernetesFluxComplianceState? complianceState, KubernetesObjectReference appliedBy, IReadOnlyList<KubernetesObjectStatusCondition> statusConditions, HelmReleaseProperties helmReleaseProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Namespace = @namespace;
            Kind = kind;
            ComplianceState = complianceState;
            AppliedBy = appliedBy;
            StatusConditions = statusConditions;
            HelmReleaseProperties = helmReleaseProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the applied object. </summary>
        public string Name { get; }
        /// <summary> Namespace of the applied object. </summary>
        public string Namespace { get; }
        /// <summary> Kind of the applied object. </summary>
        public string Kind { get; }
        /// <summary> Compliance state of the applied object showing whether the applied object has come into a ready state on the cluster. </summary>
        public KubernetesFluxComplianceState? ComplianceState { get; }
        /// <summary> Object reference to the Kustomization that applied this object. </summary>
        public KubernetesObjectReference AppliedBy { get; }
        /// <summary> List of Kubernetes object status conditions present on the cluster. </summary>
        public IReadOnlyList<KubernetesObjectStatusCondition> StatusConditions { get; }
        /// <summary> Additional properties that are provided from objects of the HelmRelease kind. </summary>
        public HelmReleaseProperties HelmReleaseProperties { get; }
    }
}
