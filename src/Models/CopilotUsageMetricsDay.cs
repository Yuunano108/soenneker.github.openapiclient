// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    /// <summary>
    /// Copilot usage metrics for a given day.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CopilotUsageMetricsDay : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Usage metrics for Copilot Chat in GitHub.com</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomChat? CopilotDotcomChat { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomChat CopilotDotcomChat { get; set; }
#endif
        /// <summary>Usage metrics for Copilot for pull requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomPullRequests? CopilotDotcomPullRequests { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomPullRequests CopilotDotcomPullRequests { get; set; }
#endif
        /// <summary>Usage metrics for Copilot Chat in the IDE.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeChat? CopilotIdeChat { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeChat CopilotIdeChat { get; set; }
#endif
        /// <summary>Usage metrics for Copilot editor code completions in the IDE.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions? CopilotIdeCodeCompletions { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions CopilotIdeCodeCompletions { get; set; }
#endif
        /// <summary>The date for which the usage metrics are aggregated, in `YYYY-MM-DD` format.</summary>
        public Date? Date { get; set; }
        /// <summary>The total number of Copilot users with activity belonging to any Copilot feature, globally, for the given day. Includes passive activity such as receiving a code suggestion, as well as engagement activity such as accepting a code suggestion or prompting chat. Does not include authentication events. Is not limited to the individual features detailed on the endpoint.</summary>
        public int? TotalActiveUsers { get; set; }
        /// <summary>The total number of Copilot users who engaged with any Copilot feature, for the given day. Examples include but are not limited to accepting a code suggestion, prompting Copilot chat, or triggering a PR Summary. Does not include authentication events. Is not limited to the individual features detailed on the endpoint.</summary>
        public int? TotalEngagedUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CopilotUsageMetricsDay"/> and sets the default values.
        /// </summary>
        public CopilotUsageMetricsDay()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CopilotUsageMetricsDay"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CopilotUsageMetricsDay CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CopilotUsageMetricsDay();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "copilot_dotcom_chat", n => { CopilotDotcomChat = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomChat>(global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomChat.CreateFromDiscriminatorValue); } },
                { "copilot_dotcom_pull_requests", n => { CopilotDotcomPullRequests = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomPullRequests>(global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomPullRequests.CreateFromDiscriminatorValue); } },
                { "copilot_ide_chat", n => { CopilotIdeChat = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeChat>(global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeChat.CreateFromDiscriminatorValue); } },
                { "copilot_ide_code_completions", n => { CopilotIdeCodeCompletions = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions>(global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions.CreateFromDiscriminatorValue); } },
                { "date", n => { Date = n.GetDateValue(); } },
                { "total_active_users", n => { TotalActiveUsers = n.GetIntValue(); } },
                { "total_engaged_users", n => { TotalEngagedUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomChat>("copilot_dotcom_chat", CopilotDotcomChat);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotDotcomPullRequests>("copilot_dotcom_pull_requests", CopilotDotcomPullRequests);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeChat>("copilot_ide_chat", CopilotIdeChat);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions>("copilot_ide_code_completions", CopilotIdeCodeCompletions);
            writer.WriteDateValue("date", Date);
            writer.WriteIntValue("total_active_users", TotalActiveUsers);
            writer.WriteIntValue("total_engaged_users", TotalEngagedUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
