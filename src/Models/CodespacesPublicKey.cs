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
    /// The public key used for setting Codespaces secrets.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CodespacesPublicKey : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The created_at property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedAt { get; set; }
#nullable restore
#else
        public string CreatedAt { get; set; }
#endif
        /// <summary>The id property</summary>
        public int? Id { get; set; }
        /// <summary>The Base64 encoded public key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The identifier for the key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyId { get; set; }
#nullable restore
#else
        public string KeyId { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CodespacesPublicKey"/> and sets the default values.
        /// </summary>
        public CodespacesPublicKey()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CodespacesPublicKey"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CodespacesPublicKey CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CodespacesPublicKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "created_at", n => { CreatedAt = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "key_id", n => { KeyId = n.GetStringValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("created_at", CreatedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("key_id", KeyId);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
