// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines a combination of configurations to use with vector search. </summary>
    public partial class VectorSearchProfile
    {
        /// <summary> Initializes a new instance of <see cref="VectorSearchProfile"/>. </summary>
        /// <param name="name"> The name to associate with this particular vector search profile. </param>
        /// <param name="algorithmConfigurationName"> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="algorithmConfigurationName"/> is null. </exception>
        public VectorSearchProfile(string name, string algorithmConfigurationName)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (algorithmConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(algorithmConfigurationName));
            }

            Name = name;
            AlgorithmConfigurationName = algorithmConfigurationName;
        }

        /// <summary> Initializes a new instance of <see cref="VectorSearchProfile"/>. </summary>
        /// <param name="name"> The name to associate with this particular vector search profile. </param>
        /// <param name="algorithmConfigurationName"> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </param>
        /// <param name="vectorizer"> The name of the kind of vectorization method being configured for use with vector search. </param>
        /// <param name="compressionConfigurationName"> The name of the compression method configuration that specifies the compression method and optional parameters. </param>
        internal VectorSearchProfile(string name, string algorithmConfigurationName, string vectorizer, string compressionConfigurationName)
        {
            Name = name;
            AlgorithmConfigurationName = algorithmConfigurationName;
            Vectorizer = vectorizer;
            CompressionConfigurationName = compressionConfigurationName;
        }

        /// <summary> The name to associate with this particular vector search profile. </summary>
        public string Name { get; set; }
        /// <summary> The name of the vector search algorithm configuration that specifies the algorithm and optional parameters. </summary>
        public string AlgorithmConfigurationName { get; set; }
        /// <summary> The name of the kind of vectorization method being configured for use with vector search. </summary>
        public string Vectorizer { get; set; }
        /// <summary> The name of the compression method configuration that specifies the compression method and optional parameters. </summary>
        public string CompressionConfigurationName { get; set; }
    }
}
