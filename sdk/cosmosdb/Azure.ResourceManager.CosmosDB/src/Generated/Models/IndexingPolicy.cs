// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB indexing policy. </summary>
    public partial class IndexingPolicy
    {
        /// <summary> Initializes a new instance of IndexingPolicy. </summary>
        public IndexingPolicy()
        {
            IncludedPaths = new ChangeTrackingList<IncludedPath>();
            ExcludedPaths = new ChangeTrackingList<ExcludedPath>();
            CompositeIndexes = new ChangeTrackingList<IList<CompositePath>>();
            SpatialIndexes = new ChangeTrackingList<SpatialSpec>();
        }

        /// <summary> Initializes a new instance of IndexingPolicy. </summary>
        /// <param name="automatic"> Indicates if the indexing policy is automatic. </param>
        /// <param name="indexingMode"> Indicates the indexing mode. </param>
        /// <param name="includedPaths"> List of paths to include in the indexing. </param>
        /// <param name="excludedPaths"> List of paths to exclude from indexing. </param>
        /// <param name="compositeIndexes"> List of composite path list. </param>
        /// <param name="spatialIndexes"> List of spatial specifics. </param>
        internal IndexingPolicy(bool? automatic, IndexingMode? indexingMode, IList<IncludedPath> includedPaths, IList<ExcludedPath> excludedPaths, IList<IList<CompositePath>> compositeIndexes, IList<SpatialSpec> spatialIndexes)
        {
            Automatic = automatic;
            IndexingMode = indexingMode;
            IncludedPaths = includedPaths;
            ExcludedPaths = excludedPaths;
            CompositeIndexes = compositeIndexes;
            SpatialIndexes = spatialIndexes;
        }

        /// <summary> Indicates if the indexing policy is automatic. </summary>
        public bool? Automatic { get; set; }
        /// <summary> Indicates the indexing mode. </summary>
        public IndexingMode? IndexingMode { get; set; }
        /// <summary> List of paths to include in the indexing. </summary>
        public IList<IncludedPath> IncludedPaths { get; }
        /// <summary> List of paths to exclude from indexing. </summary>
        public IList<ExcludedPath> ExcludedPaths { get; }
        /// <summary> List of composite path list. </summary>
        public IList<IList<CompositePath>> CompositeIndexes { get; }
        /// <summary> List of spatial specifics. </summary>
        public IList<SpatialSpec> SpatialIndexes { get; }
    }
}