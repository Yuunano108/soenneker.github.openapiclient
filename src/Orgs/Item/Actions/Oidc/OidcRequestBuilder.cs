// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Soenneker.GitHub.OpenApiClient.Orgs.Item.Actions.Oidc.Customization;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Soenneker.GitHub.OpenApiClient.Orgs.Item.Actions.Oidc
{
    /// <summary>
    /// Builds and executes requests for operations under \orgs\{org}\actions\oidc
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OidcRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The customization property</summary>
        public global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Actions.Oidc.Customization.CustomizationRequestBuilder Customization
        {
            get => new global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Actions.Oidc.Customization.CustomizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Actions.Oidc.OidcRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OidcRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/oidc", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Orgs.Item.Actions.Oidc.OidcRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OidcRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/orgs/{org}/actions/oidc", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
