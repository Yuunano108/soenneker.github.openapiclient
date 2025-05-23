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
    /// Information of a job execution in a workflow run
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Job : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The check_run_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CheckRunUrl { get; set; }
#nullable restore
#else
        public string CheckRunUrl { get; set; }
#endif
        /// <summary>The time that the job finished, in ISO 8601 format.</summary>
        public DateTimeOffset? CompletedAt { get; set; }
        /// <summary>The outcome of the job.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.Job_conclusion? Conclusion { get; set; }
        /// <summary>The time that the job created, in ISO 8601 format.</summary>
        public DateTimeOffset? CreatedAt { get; set; }
        /// <summary>The name of the current branch.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadBranch { get; set; }
#nullable restore
#else
        public string HeadBranch { get; set; }
#endif
        /// <summary>The SHA of the commit that is being run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HeadSha { get; set; }
#nullable restore
#else
        public string HeadSha { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HtmlUrl { get; set; }
#nullable restore
#else
        public string HtmlUrl { get; set; }
#endif
        /// <summary>The id of the job.</summary>
        public int? Id { get; set; }
        /// <summary>Labels for the workflow job. Specified by the &quot;runs_on&quot; attribute in the action&apos;s workflow file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Labels { get; set; }
#nullable restore
#else
        public List<string> Labels { get; set; }
#endif
        /// <summary>The name of the job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeId { get; set; }
#nullable restore
#else
        public string NodeId { get; set; }
#endif
        /// <summary>Attempt number of the associated workflow run, 1 for first attempt and higher if the workflow was re-run.</summary>
        public int? RunAttempt { get; set; }
        /// <summary>The id of the associated workflow run.</summary>
        public int? RunId { get; set; }
        /// <summary>The ID of the runner group to which this job has been assigned. (If a runner hasn&apos;t yet been assigned, this will be null.)</summary>
        public int? RunnerGroupId { get; set; }
        /// <summary>The name of the runner group to which this job has been assigned. (If a runner hasn&apos;t yet been assigned, this will be null.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunnerGroupName { get; set; }
#nullable restore
#else
        public string RunnerGroupName { get; set; }
#endif
        /// <summary>The ID of the runner to which this job has been assigned. (If a runner hasn&apos;t yet been assigned, this will be null.)</summary>
        public int? RunnerId { get; set; }
        /// <summary>The name of the runner to which this job has been assigned. (If a runner hasn&apos;t yet been assigned, this will be null.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunnerName { get; set; }
#nullable restore
#else
        public string RunnerName { get; set; }
#endif
        /// <summary>The run_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunUrl { get; set; }
#nullable restore
#else
        public string RunUrl { get; set; }
#endif
        /// <summary>The time that the job started, in ISO 8601 format.</summary>
        public DateTimeOffset? StartedAt { get; set; }
        /// <summary>The phase of the lifecycle that the job is currently in.</summary>
        public global::Soenneker.GitHub.OpenApiClient.Models.Job_status? Status { get; set; }
        /// <summary>Steps in this job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.Models.Job_steps>? Steps { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.Models.Job_steps> Steps { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The name of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkflowName { get; set; }
#nullable restore
#else
        public string WorkflowName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.Job"/> and sets the default values.
        /// </summary>
        public Job()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.Job"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.Job CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.Job();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "check_run_url", n => { CheckRunUrl = n.GetStringValue(); } },
                { "completed_at", n => { CompletedAt = n.GetDateTimeOffsetValue(); } },
                { "conclusion", n => { Conclusion = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.Job_conclusion>(); } },
                { "created_at", n => { CreatedAt = n.GetDateTimeOffsetValue(); } },
                { "head_branch", n => { HeadBranch = n.GetStringValue(); } },
                { "head_sha", n => { HeadSha = n.GetStringValue(); } },
                { "html_url", n => { HtmlUrl = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "labels", n => { Labels = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "node_id", n => { NodeId = n.GetStringValue(); } },
                { "run_attempt", n => { RunAttempt = n.GetIntValue(); } },
                { "run_id", n => { RunId = n.GetIntValue(); } },
                { "run_url", n => { RunUrl = n.GetStringValue(); } },
                { "runner_group_id", n => { RunnerGroupId = n.GetIntValue(); } },
                { "runner_group_name", n => { RunnerGroupName = n.GetStringValue(); } },
                { "runner_id", n => { RunnerId = n.GetIntValue(); } },
                { "runner_name", n => { RunnerName = n.GetStringValue(); } },
                { "started_at", n => { StartedAt = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.Job_status>(); } },
                { "steps", n => { Steps = n.GetCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.Job_steps>(global::Soenneker.GitHub.OpenApiClient.Models.Job_steps.CreateFromDiscriminatorValue)?.AsList(); } },
                { "url", n => { Url = n.GetStringValue(); } },
                { "workflow_name", n => { WorkflowName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("check_run_url", CheckRunUrl);
            writer.WriteDateTimeOffsetValue("completed_at", CompletedAt);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.Job_conclusion>("conclusion", Conclusion);
            writer.WriteDateTimeOffsetValue("created_at", CreatedAt);
            writer.WriteStringValue("head_branch", HeadBranch);
            writer.WriteStringValue("head_sha", HeadSha);
            writer.WriteStringValue("html_url", HtmlUrl);
            writer.WriteIntValue("id", Id);
            writer.WriteCollectionOfPrimitiveValues<string>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", NodeId);
            writer.WriteIntValue("run_attempt", RunAttempt);
            writer.WriteIntValue("run_id", RunId);
            writer.WriteIntValue("runner_group_id", RunnerGroupId);
            writer.WriteStringValue("runner_group_name", RunnerGroupName);
            writer.WriteIntValue("runner_id", RunnerId);
            writer.WriteStringValue("runner_name", RunnerName);
            writer.WriteStringValue("run_url", RunUrl);
            writer.WriteDateTimeOffsetValue("started_at", StartedAt);
            writer.WriteEnumValue<global::Soenneker.GitHub.OpenApiClient.Models.Job_status>("status", Status);
            writer.WriteCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.Job_steps>("steps", Steps);
            writer.WriteStringValue("url", Url);
            writer.WriteStringValue("workflow_name", WorkflowName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
