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
    /// A CodeQL database.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CodeScanningCodeqlDatabase : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The commit SHA of the repository at the time the CodeQL database was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommitOid { get; set; }
#nullable restore
#else
        public string CommitOid { get; set; }
#endif
        /// <summary>The MIME type of the CodeQL database file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType { get; set; }
#nullable restore
#else
        public string ContentType { get; set; }
#endif
        /// <summary>The date and time at which the CodeQL database was created, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The ID of the CodeQL database.</summary>
        public int? Id { get; set; }
        /// <summary>The language of the CodeQL database.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>The name of the CodeQL database.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The size of the CodeQL database file in bytes.</summary>
        public int? Size { get; set; }
        /// <summary>The date and time at which the CodeQL database was last updated, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser? Uploader { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser Uploader { get; set; }
#endif
        /// <summary>The URL at which to download the CodeQL database. The `Accept` header must be set to the value of the `content_type` property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningCodeqlDatabase"/> and sets the default values.
        /// </summary>
        public CodeScanningCodeqlDatabase()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningCodeqlDatabase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningCodeqlDatabase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CodeScanningCodeqlDatabase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "commit_oid", n => { CommitOid = n.GetStringValue(); } },
                { "content_type", n => { ContentType = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "size", n => { Size = n.GetIntValue(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
                { "uploader", n => { Uploader = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("commit_oid", CommitOid);
            writer.WriteStringValue("content_type", ContentType);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("size", Size);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>("uploader", Uploader);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
