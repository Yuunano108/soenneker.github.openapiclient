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
    /// Provides details of a hosted runner image
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ActionsHostedRunnerPoolImage : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name for this image.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The ID of the image. Use this ID for the `image` parameter when creating a new larger runner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Image size in GB.</summary>
        public int? SizeGb { get; set; }
        /// <summary>The image provider.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage_source? Source { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage"/> and sets the default values.
        /// </summary>
        public ActionsHostedRunnerPoolImage()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "display_name", n => { DisplayName = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "size_gb", n => { SizeGb = n.GetIntValue(); } },
                { "source", n => { Source = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage_source>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("display_name", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("size_gb", SizeGb);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.ActionsHostedRunnerPoolImage_source>("source", Source);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
