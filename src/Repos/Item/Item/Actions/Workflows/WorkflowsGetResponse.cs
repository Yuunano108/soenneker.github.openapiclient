// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Soenneker.GitHub.OpenApiClient.Models;
using System.Collections.Generic;
using System.IO;
using System;
namespace Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Workflows
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WorkflowsGetResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The total_count property</summary>
        public int? TotalCount { get; set; }
        /// <summary>The workflows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.Models.Workflow>? Workflows { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.Models.Workflow> Workflows { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Workflows.WorkflowsGetResponse"/> and sets the default values.
        /// </summary>
        public WorkflowsGetResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Workflows.WorkflowsGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Workflows.WorkflowsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Repos.Item.Item.Actions.Workflows.WorkflowsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "total_count", n => { TotalCount = n.GetIntValue(); } },
                { "workflows", n => { Workflows = n.GetCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.Workflow>(global::Soenneker.GitHub.OpenApiClient.Models.Workflow.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("total_count", TotalCount);
            writer.WriteCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.Workflow>("workflows", Workflows);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
