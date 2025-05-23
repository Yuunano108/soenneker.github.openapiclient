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
    /// A credit given to a user for a repository security advisory.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RepositoryAdvisoryCredit : IParsable
    {
        /// <summary>The state of the user&apos;s acceptance of the credit.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.RepositoryAdvisoryCredit_state? State { get; set; }
        /// <summary>The type of credit the user is receiving.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.SecurityAdvisoryCreditTypes? Type { get; set; }
        /// <summary>A GitHub user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser? User { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser User { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.RepositoryAdvisoryCredit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.RepositoryAdvisoryCredit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.RepositoryAdvisoryCredit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "state", n => { State = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RepositoryAdvisoryCredit_state>(); } },
                { "type", n => { Type = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.SecurityAdvisoryCreditTypes>(); } },
                { "user", n => { User = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.RepositoryAdvisoryCredit_state>("state", State);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.SecurityAdvisoryCreditTypes>("type", Type);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleUser>("user", User);
        }
    }
}
#pragma warning restore CS0618
