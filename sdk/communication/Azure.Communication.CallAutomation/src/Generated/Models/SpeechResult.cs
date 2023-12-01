// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The speech recognition status as a result. </summary>
    public partial class SpeechResult
    {
        /// <summary> Initializes a new instance of <see cref="SpeechResult"/>. </summary>
        internal SpeechResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SpeechResult"/>. </summary>
        /// <param name="speech"> The recognized speech in string. </param>
        internal SpeechResult(string speech)
        {
            Speech = speech;
        }

        /// <summary> The recognized speech in string. </summary>
        public string Speech { get; }
    }
}
