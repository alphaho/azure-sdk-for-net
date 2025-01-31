// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.OpenAI
{
    /// <summary> A representation of the log probability information for a single content token, including a list of most likely tokens if 'top_logprobs' were requested. </summary>
    public partial class ChatTokenLogProbabilityResult
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

        /// <summary> Initializes a new instance of <see cref="ChatTokenLogProbabilityResult"/>. </summary>
        /// <param name="token"> The message content token. </param>
        /// <param name="logProbability"> The log probability of the message content token. </param>
        /// <param name="utf8ByteValues"> A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be null if there is no bytes representation for the token. </param>
        /// <param name="topLogProbabilityEntries"> The list of most likely tokens and their log probability information, as requested via 'top_logprobs'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/> is null. </exception>
        internal ChatTokenLogProbabilityResult(string token, float logProbability, IEnumerable<int> utf8ByteValues, IEnumerable<ChatTokenLogProbabilityInfo> topLogProbabilityEntries)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));
            }

            Token = token;
            LogProbability = logProbability;
            Utf8ByteValues = utf8ByteValues?.ToList();
            TopLogProbabilityEntries = topLogProbabilityEntries?.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatTokenLogProbabilityResult"/>. </summary>
        /// <param name="token"> The message content token. </param>
        /// <param name="logProbability"> The log probability of the message content token. </param>
        /// <param name="utf8ByteValues"> A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be null if there is no bytes representation for the token. </param>
        /// <param name="topLogProbabilityEntries"> The list of most likely tokens and their log probability information, as requested via 'top_logprobs'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatTokenLogProbabilityResult(string token, float logProbability, IReadOnlyList<int> utf8ByteValues, IReadOnlyList<ChatTokenLogProbabilityInfo> topLogProbabilityEntries, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8ByteValues = utf8ByteValues;
            TopLogProbabilityEntries = topLogProbabilityEntries;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatTokenLogProbabilityResult"/> for deserialization. </summary>
        internal ChatTokenLogProbabilityResult()
        {
        }

        /// <summary> The message content token. </summary>
        public string Token { get; }
        /// <summary> The log probability of the message content token. </summary>
        public float LogProbability { get; }
        /// <summary> A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be null if there is no bytes representation for the token. </summary>
        public IReadOnlyList<int> Utf8ByteValues { get; }
        /// <summary> The list of most likely tokens and their log probability information, as requested via 'top_logprobs'. </summary>
        public IReadOnlyList<ChatTokenLogProbabilityInfo> TopLogProbabilityEntries { get; }
    }
}
