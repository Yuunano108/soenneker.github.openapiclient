// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    /// <summary>
    /// Pages Health Check Status
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PagesHealthCheck : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alt_domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_alt_domain? AltDomain { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_alt_domain AltDomain { get; set; }
#endif
        /// <summary>The domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_domain? Domain { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_domain Domain { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck"/> and sets the default values.
        /// </summary>
        public PagesHealthCheck()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alt_domain", n => { AltDomain = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_alt_domain>(global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_alt_domain.CreateFromDiscriminatorValue); } },
                { "domain", n => { Domain = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_domain>(global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_domain.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_alt_domain>("alt_domain", AltDomain);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.PagesHealthCheck_domain>("domain", Domain);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
