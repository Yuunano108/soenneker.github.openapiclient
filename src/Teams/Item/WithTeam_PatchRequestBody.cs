// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Teams.Item
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WithTeam_PatchRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are:  * `notifications_enabled` - team members receive notifications when the team is @mentioned.   * `notifications_disabled` - no one receives notifications.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_notification_setting? NotificationSetting { get; set; }
        /// <summary>The ID of a team to set as the parent team.</summary>
        public int? ParentTeamId { get; set; }
        /// <summary>**Closing down notice**. The permission that new repositories will be added to the team with when none is specified.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_permission? Permission { get; set; }
        /// <summary>The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:  **For a non-nested team:**   * `secret` - only visible to organization owners and members of this team.   * `closed` - visible to all members of this organization.  **For a parent or child team:**   * `closed` - visible to all members of this organization.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_privacy? Privacy { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody"/> and sets the default values.
        /// </summary>
        public WithTeam_PatchRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
            Permission = global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_permission.Pull;
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "notification_setting", n => { NotificationSetting = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_notification_setting>(); } },
                { "parent_team_id", n => { ParentTeamId = n.GetIntValue(); } },
                { "permission", n => { Permission = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_permission>(); } },
                { "privacy", n => { Privacy = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_privacy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_notification_setting>("notification_setting", NotificationSetting);
            writer.WriteIntValue("parent_team_id", ParentTeamId);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_permission>("permission", Permission);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Teams.Item.WithTeam_PatchRequestBody_privacy>("privacy", Privacy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
