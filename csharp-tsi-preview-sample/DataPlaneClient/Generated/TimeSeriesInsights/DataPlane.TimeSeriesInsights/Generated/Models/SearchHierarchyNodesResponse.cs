// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The hierarchy nodes which contains the instances matching the query
    /// based on the input. May be empty or null.
    /// </summary>
    public partial class SearchHierarchyNodesResponse
    {
        /// <summary>
        /// Initializes a new instance of the SearchHierarchyNodesResponse
        /// class.
        /// </summary>
        public SearchHierarchyNodesResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SearchHierarchyNodesResponse
        /// class.
        /// </summary>
        /// <param name="hits">The list of hierarchy nodes which contains the
        /// instances matching the query based on the input. May be
        /// empty.</param>
        /// <param name="hitCount">Total number of hierarchy nodes which
        /// contains the instances matching the query based on the
        /// input.</param>
        /// <param name="continuationToken">If returned, this means that
        /// current results represent a partial result. Continuation token
        /// allows to get the next page of results. To get the next page of
        /// query results, send the same request with continuation token
        /// parameter in "x-ms-continuation" HTTP header.</param>
        public SearchHierarchyNodesResponse(IList<HierarchyHit> hits = default(IList<HierarchyHit>), int? hitCount = default(int?), string continuationToken = default(string))
        {
            Hits = hits;
            HitCount = hitCount;
            ContinuationToken = continuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of hierarchy nodes which contains the instances
        /// matching the query based on the input. May be empty.
        /// </summary>
        [JsonProperty(PropertyName = "hits")]
        public IList<HierarchyHit> Hits { get; private set; }

        /// <summary>
        /// Gets total number of hierarchy nodes which contains the instances
        /// matching the query based on the input.
        /// </summary>
        [JsonProperty(PropertyName = "hitCount")]
        public int? HitCount { get; private set; }

        /// <summary>
        /// Gets if returned, this means that current results represent a
        /// partial result. Continuation token allows to get the next page of
        /// results. To get the next page of query results, send the same
        /// request with continuation token parameter in "x-ms-continuation"
        /// HTTP header.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; private set; }

    }
}