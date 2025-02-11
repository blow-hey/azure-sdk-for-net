// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The UnknownCredentials. </summary>
    internal partial class UnknownCredentials : StorageMoverCredentials
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCredentials"/>. </summary>
        /// <param name="credentialType"> The Credentials type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCredentials(CredentialType credentialType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(credentialType, serializedAdditionalRawData)
        {
            CredentialType = credentialType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCredentials"/> for deserialization. </summary>
        internal UnknownCredentials()
        {
        }
    }
}
