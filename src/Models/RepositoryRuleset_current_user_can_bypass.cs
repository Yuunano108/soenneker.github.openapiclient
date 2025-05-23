// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    /// <summary>The bypass type of the user making the API request for this ruleset. This field is only returned whenquerying the repository-level endpoint.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum RepositoryRuleset_current_user_can_bypass
    {
        [EnumMember(Value = "always")]
        #pragma warning disable CS1591
        Always,
        #pragma warning restore CS1591
        [EnumMember(Value = "pull_requests_only")]
        #pragma warning disable CS1591
        Pull_requests_only,
        #pragma warning restore CS1591
        [EnumMember(Value = "never")]
        #pragma warning disable CS1591
        Never,
        #pragma warning restore CS1591
    }
}
