// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Models;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.CheckRuns;
using Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.Rerequest;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \repos\{owner-id}\{repo-id}\check-suites\{check_suite_id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithCheck_suite_ItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The checkRuns property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder CheckRuns
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.CheckRuns.CheckRunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rerequest property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.Rerequest.RerequestRequestBuilder Rerequest
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.Rerequest.RerequestRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCheck_suite_ItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-suites/{check_suite_id}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithCheck_suite_ItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/repos/{owner%2Did}/{repo%2Did}/check-suites/{check_suite_id}", rawUrl)
        {
        }
        /// <summary>
        /// Gets a single check suite using its `id`.&gt; [!NOTE]&gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// API method documentation <see href="https://docs.github.com/rest/checks/suites#get-a-check-suite" />
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CheckSuite"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Soenneker.GitHub.OpenApiClient.Models.CheckSuite?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Soenneker.GitHub.OpenApiClient.Models.CheckSuite> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<global::Soenneker.GitHub.OpenApiClient.Models.CheckSuite>(requestInfo, global::Soenneker.GitHub.OpenApiClient.Models.CheckSuite.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets a single check suite using its `id`.&gt; [!NOTE]&gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array and a `null` value for `head_branch`.OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.CheckSuites.Item.WithCheck_suite_ItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class WithCheck_suite_ItemRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
