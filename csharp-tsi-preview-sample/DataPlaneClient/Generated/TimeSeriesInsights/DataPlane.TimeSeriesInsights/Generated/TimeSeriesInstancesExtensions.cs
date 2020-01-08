// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TimeSeriesInstances.
    /// </summary>
    public static partial class TimeSeriesInstancesExtensions
    {
            /// <summary>
            /// Gets time series instances in pages.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='continuationToken'>
            /// Continuation token from previous page of results to retrieve the next page
            /// of the results in calls that support pagination. To get the first page
            /// results, specify null continuation token as parameter value. Returned
            /// continuation token is null if all results have been returned, and there is
            /// no next page of results.
            /// </param>
            /// <param name='clientRequestId'>
            /// Optional client request ID. Service records this value. Allows the service
            /// to trace operation across services, and allows the customer to contact
            /// support regarding a particular request.
            /// </param>
            /// <param name='clientSessionId'>
            /// Optional client session ID. Service records this value. Allows the service
            /// to trace a group of related operations across services, and allows the
            /// customer to contact support regarding a particular group of requests.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetInstancesPage> GetAsync(this ITimeSeriesInstances operations, string continuationToken = default(string), string clientRequestId = default(string), string clientSessionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(continuationToken, clientRequestId, clientSessionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Executes a batch get, create, update, delete operation on multiple time
            /// series instances.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Time series instances suggest request body.
            /// </param>
            /// <param name='clientRequestId'>
            /// Optional client request ID. Service records this value. Allows the service
            /// to trace operation across services, and allows the customer to contact
            /// support regarding a particular request.
            /// </param>
            /// <param name='clientSessionId'>
            /// Optional client session ID. Service records this value. Allows the service
            /// to trace a group of related operations across services, and allows the
            /// customer to contact support regarding a particular group of requests.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InstancesBatchResponse> ExecuteBatchAsync(this ITimeSeriesInstances operations, InstancesBatchRequest parameters, string clientRequestId = default(string), string clientSessionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ExecuteBatchWithHttpMessagesAsync(parameters, clientRequestId, clientSessionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Suggests keywords based on time series instance attributes to be later used
            /// in Search Instances.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Time series instances suggest request body.
            /// </param>
            /// <param name='clientRequestId'>
            /// Optional client request ID. Service records this value. Allows the service
            /// to trace operation across services, and allows the customer to contact
            /// support regarding a particular request.
            /// </param>
            /// <param name='clientSessionId'>
            /// Optional client session ID. Service records this value. Allows the service
            /// to trace a group of related operations across services, and allows the
            /// customer to contact support regarding a particular group of requests.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InstancesSuggestResponse> SuggestAsync(this ITimeSeriesInstances operations, InstancesSuggestRequest parameters, string clientRequestId = default(string), string clientSessionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SuggestWithHttpMessagesAsync(parameters, clientRequestId, clientSessionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Partial list of hits on search for time series instances based on instance
            /// attributes.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Time series instances search request body.
            /// </param>
            /// <param name='continuationToken'>
            /// Continuation token from previous page of results to retrieve the next page
            /// of the results in calls that support pagination. To get the first page
            /// results, specify null continuation token as parameter value. Returned
            /// continuation token is null if all results have been returned, and there is
            /// no next page of results.
            /// </param>
            /// <param name='clientRequestId'>
            /// Optional client request ID. Service records this value. Allows the service
            /// to trace operation across services, and allows the customer to contact
            /// support regarding a particular request.
            /// </param>
            /// <param name='clientSessionId'>
            /// Optional client session ID. Service records this value. Allows the service
            /// to trace a group of related operations across services, and allows the
            /// customer to contact support regarding a particular group of requests.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SearchInstancesResponsePage> SearchAsync(this ITimeSeriesInstances operations, SearchInstancesRequest parameters, string continuationToken = default(string), string clientRequestId = default(string), string clientSessionId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SearchWithHttpMessagesAsync(parameters, continuationToken, clientRequestId, clientSessionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}