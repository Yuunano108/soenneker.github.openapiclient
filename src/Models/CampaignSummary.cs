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
    /// The campaign metadata and alert stats.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CampaignSummary : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alert_stats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary_alert_stats? AlertStats { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary_alert_stats AlertStats { get; set; }
#endif
        /// <summary>The date and time the campaign was closed, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ. Will be null if the campaign is still open.</summary>
        public DateTimeOffset? ClosedAt { get; set; }
        /// <summary>The contact link of the campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactLink { get; set; }
#nullable restore
#else
        public string ContactLink { get; set; }
#endif
        /// <summary>The date and time the campaign was created, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The campaign description</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The date and time the campaign has ended, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? EndsAt { get; set; }
        /// <summary>The campaign managers</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>? Managers { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser> Managers { get; set; }
#endif
        /// <summary>The campaign name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The number of the newly created campaign</summary>
        public int? Number { get; set; }
        /// <summary>The date and time the campaign was published, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? PublishedAt { get; set; }
        /// <summary>Indicates whether a campaign is open or closed</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.CampaignState? State { get; set; }
        /// <summary>The campaign team managers</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.Models.Team>? TeamManagers { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.Models.Team> TeamManagers { get; set; }
#endif
        /// <summary>The date and time the campaign was last updated, in ISO 8601 format&apos;:&apos; YYYY-MM-DDTHH:MM:SSZ.</summary>
        public DateTimeOffset? UpdatedAt { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary"/> and sets the default values.
        /// </summary>
        public CampaignSummary()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "alert_stats", n => { AlertStats = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary_alert_stats>(global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary_alert_stats.CreateFromDiscriminatorValue); } },
                { "closed_at", n => { ClosedAt = n.GetDateTimeOffsetValue(); } },
                { "contact_link", n => { ContactLink = n.GetStringValue(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "ends_at", n => { EndsAt = n.GetDateTimeOffsetValue(); } },
                { "managers", n => { Managers = n.GetCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "number", n => { Number = n.GetIntValue(); } },
                { "published_at", n => { PublishedAt = n.GetDateTimeOffsetValue(); } },
                { "state", n => { State = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CampaignState>(); } },
                { "team_managers", n => { TeamManagers = n.GetCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.Team>(global::Soenneker.GitHub.OpenApiClient.Models.Team.CreateFromDiscriminatorValue)?.AsList(); } },
                { "updated_at", n => { UpdatedAt = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CampaignSummary_alert_stats>("alert_stats", AlertStats);
            writer.WriteDateTimeOffsetValue("closed_at", ClosedAt);
            writer.WriteStringValue("contact_link", ContactLink);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("ends_at", EndsAt);
            writer.WriteCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>("managers", Managers);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("number", Number);
            writer.WriteDateTimeOffsetValue("published_at", PublishedAt);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.CampaignState>("state", State);
            writer.WriteCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.Team>("team_managers", TeamManagers);
            writer.WriteDateTimeOffsetValue("updated_at", UpdatedAt);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
