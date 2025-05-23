// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class HooksPostRequestBody : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Determines if notifications are sent when the webhook is triggered. Set to `true` to send notifications.</summary>
        public bool? Active { get; set; }
        /// <summary>Key/value pairs to provide settings for this webhook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody_config? Config { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody_config Config { get; set; }
#endif
        /// <summary>Determines what [events](https://docs.github.com/webhooks/event-payloads) the hook is triggered for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Events { get; set; }
#nullable restore
#else
        public List<string> Events { get; set; }
#endif
        /// <summary>Use `web` to create a webhook. Default: `web`. This parameter only accepts the value `web`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "active", n => { Active = n.GetBoolValue(); } },
                { "config", n => { Config = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody_config>(global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody_config.CreateFromDiscriminatorValue); } },
                { "events", n => { Events = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("active", Active);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Hooks.HooksPostRequestBody_config>("config", Config);
            writer.WriteCollectionOfPrimitiveValues<string>("events", Events);
            writer.WriteStringValue("name", Name);
        }
    }
}
#pragma warning restore CS0618
