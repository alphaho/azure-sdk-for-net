// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra table resource object. </summary>
    public partial class CassandraTableResourceInfo
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CassandraTableResourceInfo"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB Cassandra table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        public CassandraTableResourceInfo(string tableName)
        {
            if (tableName == null)
            {
                throw new ArgumentNullException(nameof(tableName));
            }

            TableName = tableName;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraTableResourceInfo"/>. </summary>
        /// <param name="tableName"> Name of the Cosmos DB Cassandra table. </param>
        /// <param name="defaultTtl"> Time to live of the Cosmos DB Cassandra table. </param>
        /// <param name="schema"> Schema of the Cosmos DB Cassandra table. </param>
        /// <param name="analyticalStorageTtl"> Analytical TTL. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CassandraTableResourceInfo(string tableName, int? defaultTtl, CassandraSchema schema, int? analyticalStorageTtl, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TableName = tableName;
            DefaultTtl = defaultTtl;
            Schema = schema;
            AnalyticalStorageTtl = analyticalStorageTtl;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CassandraTableResourceInfo"/> for deserialization. </summary>
        internal CassandraTableResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB Cassandra table. </summary>
        public string TableName { get; set; }
        /// <summary> Time to live of the Cosmos DB Cassandra table. </summary>
        public int? DefaultTtl { get; set; }
        /// <summary> Schema of the Cosmos DB Cassandra table. </summary>
        public CassandraSchema Schema { get; set; }
        /// <summary> Analytical TTL. </summary>
        public int? AnalyticalStorageTtl { get; set; }
    }
}
