// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The UnknownAdditionalData. </summary>
    internal partial class UnknownAdditionalData : SecuritySubAssessmentAdditionalInfo
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAdditionalData"/>. </summary>
        /// <param name="assessedResourceType"> Sub-assessment resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAdditionalData(AssessedResourceType assessedResourceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(assessedResourceType, serializedAdditionalRawData)
        {
            AssessedResourceType = assessedResourceType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAdditionalData"/> for deserialization. </summary>
        internal UnknownAdditionalData()
        {
        }
    }
}
