// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\code-scanning
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CodeScanningRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The alerts property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder Alerts
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.Alerts.AlertsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.CodeScanningRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeScanningRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/code-scanning", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.CodeScanning.CodeScanningRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CodeScanningRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/code-scanning", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
