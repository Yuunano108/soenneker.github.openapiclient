// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CopilotIdeCodeCompletions_editors_models : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The training date for the custom model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomModelTrainingDate { get; set; }
#nullable restore
#else
        public string CustomModelTrainingDate { get; set; }
#endif
        /// <summary>Indicates whether a model is custom or default.</summary>
        public bool? IsCustomModel { get; set; }
        /// <summary>Code completion metrics for active languages, for the given editor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models_languages>? Languages { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models_languages> Languages { get; set; }
#endif
        /// <summary>Name of the model used for Copilot code completion suggestions. If the default model is used will appear as &apos;default&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Number of users who accepted at least one Copilot code completion suggestion for the given editor, for the given language and model. Includes both full and partial acceptances.</summary>
        public int? TotalEngagedUsers { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models"/> and sets the default values.
        /// </summary>
        public CopilotIdeCodeCompletions_editors_models()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "custom_model_training_date", n => { CustomModelTrainingDate = n.GetStringValue(); } },
                { "is_custom_model", n => { IsCustomModel = n.GetBoolValue(); } },
                { "languages", n => { Languages = n.GetCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models_languages>(global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models_languages.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
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
            writer.WriteStringValue("custom_model_training_date", CustomModelTrainingDate);
            writer.WriteBoolValue("is_custom_model", IsCustomModel);
            writer.WriteCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.CopilotIdeCodeCompletions_editors_models_languages>("languages", Languages);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("total_engaged_users", TotalEngagedUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
