// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.User.Migrations
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MigrationsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Exclude attributes from the API response to improve performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody_exclude?>? Exclude { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody_exclude?> Exclude { get; set; }
#endif
        /// <summary>Do not include attachments in the migration</summary>
        public bool? ExcludeAttachments { get; set; }
        /// <summary>Indicates whether the repository git data should be excluded from the migration.</summary>
        public bool? ExcludeGitData { get; set; }
        /// <summary>Indicates whether metadata should be excluded and only git source should be included for the migration.</summary>
        public bool? ExcludeMetadata { get; set; }
        /// <summary>Indicates whether projects owned by the organization or users should be excluded.</summary>
        public bool? ExcludeOwnerProjects { get; set; }
        /// <summary>Do not include releases in the migration</summary>
        public bool? ExcludeReleases { get; set; }
        /// <summary>Lock the repositories being migrated at the start of the migration</summary>
        public bool? LockRepositories { get; set; }
        /// <summary>Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).</summary>
        public bool? OrgMetadataOnly { get; set; }
        /// <summary>The repositories property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Repositories { get; set; }
#nullable restore
#else
        public List<string> Repositories { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody"/> and sets the default values.
        /// </summary>
        public MigrationsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "exclude", n => { Exclude = n.GetCollectionOfEnumValues<global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody_exclude>()?.AsList(); } },
                { "exclude_attachments", n => { ExcludeAttachments = n.GetBoolValue(); } },
                { "exclude_git_data", n => { ExcludeGitData = n.GetBoolValue(); } },
                { "exclude_metadata", n => { ExcludeMetadata = n.GetBoolValue(); } },
                { "exclude_owner_projects", n => { ExcludeOwnerProjects = n.GetBoolValue(); } },
                { "exclude_releases", n => { ExcludeReleases = n.GetBoolValue(); } },
                { "lock_repositories", n => { LockRepositories = n.GetBoolValue(); } },
                { "org_metadata_only", n => { OrgMetadataOnly = n.GetBoolValue(); } },
                { "repositories", n => { Repositories = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<global::Soenneker.GitHub.OpenApiClient.User.Migrations.MigrationsPostRequestBody_exclude>("exclude", Exclude);
            writer.WriteBoolValue("exclude_attachments", ExcludeAttachments);
            writer.WriteBoolValue("exclude_git_data", ExcludeGitData);
            writer.WriteBoolValue("exclude_metadata", ExcludeMetadata);
            writer.WriteBoolValue("exclude_owner_projects", ExcludeOwnerProjects);
            writer.WriteBoolValue("exclude_releases", ExcludeReleases);
            writer.WriteBoolValue("lock_repositories", LockRepositories);
            writer.WriteBoolValue("org_metadata_only", OrgMetadataOnly);
            writer.WriteCollectionOfPrimitiveValues<string>("repositories", Repositories);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
