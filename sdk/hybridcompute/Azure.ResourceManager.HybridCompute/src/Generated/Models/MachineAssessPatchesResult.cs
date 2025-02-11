// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes the properties of an AssessPatches result. </summary>
    public partial class MachineAssessPatchesResult
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

        /// <summary> Initializes a new instance of <see cref="MachineAssessPatchesResult"/>. </summary>
        internal MachineAssessPatchesResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineAssessPatchesResult"/>. </summary>
        /// <param name="status"> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </param>
        /// <param name="assessmentActivityId"> The activity ID of the operation that produced this result. </param>
        /// <param name="isRebootPending"> The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred. </param>
        /// <param name="availablePatchCountByClassification"> Summarization of patches available for installation on the machine by classification. </param>
        /// <param name="startOn"> The UTC timestamp when the operation began. </param>
        /// <param name="lastModifiedOn"> The UTC timestamp when the operation finished. </param>
        /// <param name="startedBy"> Indicates if operation was triggered by user or by platform. </param>
        /// <param name="patchServiceUsed"> Specifies the patch service used for the operation. </param>
        /// <param name="osType"> The operating system type of the machine. </param>
        /// <param name="errorDetails"> The errors that were encountered during execution of the operation. The details array contains the list of them. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineAssessPatchesResult(MachineOperationStatus? status, Guid? assessmentActivityId, bool? isRebootPending, AvailablePatchCountByClassification availablePatchCountByClassification, DateTimeOffset? startOn, DateTimeOffset? lastModifiedOn, PatchOperationStartedBy? startedBy, PatchServiceUsed? patchServiceUsed, HybridComputeOSType? osType, ResponseError errorDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            AssessmentActivityId = assessmentActivityId;
            IsRebootPending = isRebootPending;
            AvailablePatchCountByClassification = availablePatchCountByClassification;
            StartOn = startOn;
            LastModifiedOn = lastModifiedOn;
            StartedBy = startedBy;
            PatchServiceUsed = patchServiceUsed;
            OSType = osType;
            ErrorDetails = errorDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </summary>
        public MachineOperationStatus? Status { get; }
        /// <summary> The activity ID of the operation that produced this result. </summary>
        public Guid? AssessmentActivityId { get; }
        /// <summary> The overall reboot status of the VM. It will be true when partially installed patches require a reboot to complete installation but the reboot has not yet occurred. </summary>
        public bool? IsRebootPending { get; }
        /// <summary> Summarization of patches available for installation on the machine by classification. </summary>
        public AvailablePatchCountByClassification AvailablePatchCountByClassification { get; }
        /// <summary> The UTC timestamp when the operation began. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The UTC timestamp when the operation finished. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Indicates if operation was triggered by user or by platform. </summary>
        public PatchOperationStartedBy? StartedBy { get; }
        /// <summary> Specifies the patch service used for the operation. </summary>
        public PatchServiceUsed? PatchServiceUsed { get; }
        /// <summary> The operating system type of the machine. </summary>
        public HybridComputeOSType? OSType { get; }
        /// <summary> The errors that were encountered during execution of the operation. The details array contains the list of them. </summary>
        public ResponseError ErrorDetails { get; }
    }
}
