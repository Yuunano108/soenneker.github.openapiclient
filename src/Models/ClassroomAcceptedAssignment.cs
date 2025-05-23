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
    /// A GitHub Classroom accepted assignment
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ClassroomAcceptedAssignment : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A GitHub Classroom assignment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomAssignment? Assignment { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomAssignment Assignment { get; set; }
#endif
        /// <summary>Count of student commits.</summary>
        public int? CommitCount { get; set; }
        /// <summary>Most recent grade.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Grade { get; set; }
#nullable restore
#else
        public string Grade { get; set; }
#endif
        /// <summary>Unique identifier of the repository.</summary>
        public int? Id { get; set; }
        /// <summary>Whether a submission passed.</summary>
        public bool? Passing { get; set; }
        /// <summary>A GitHub repository view for Classroom</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomRepository? Repository { get; set; }
#nullable restore
#else
        public global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomRepository Repository { get; set; }
#endif
        /// <summary>The students property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomUser>? Students { get; set; }
#nullable restore
#else
        public List<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomUser> Students { get; set; }
#endif
        /// <summary>Whether an accepted assignment has been submitted.</summary>
        public bool? Submitted { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::Soenneker.GitHub.OpenApiClient.Models.ClassroomAcceptedAssignment"/> and sets the default values.
        /// </summary>
        public ClassroomAcceptedAssignment()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Soenneker.GitHub.OpenApiClient.Models.ClassroomAcceptedAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Soenneker.GitHub.OpenApiClient.Models.ClassroomAcceptedAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Soenneker.GitHub.OpenApiClient.Models.ClassroomAcceptedAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignment", n => { Assignment = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomAssignment>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomAssignment.CreateFromDiscriminatorValue); } },
                { "commit_count", n => { CommitCount = n.GetIntValue(); } },
                { "grade", n => { Grade = n.GetStringValue(); } },
                { "id", n => { Id = n.GetIntValue(); } },
                { "passing", n => { Passing = n.GetBoolValue(); } },
                { "repository", n => { Repository = n.GetObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomRepository>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomRepository.CreateFromDiscriminatorValue); } },
                { "students", n => { Students = n.GetCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomUser>(global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomUser.CreateFromDiscriminatorValue)?.AsList(); } },
                { "submitted", n => { Submitted = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomAssignment>("assignment", Assignment);
            writer.WriteIntValue("commit_count", CommitCount);
            writer.WriteStringValue("grade", Grade);
            writer.WriteIntValue("id", Id);
            writer.WriteBoolValue("passing", Passing);
            writer.WriteObjectValue<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomRepository>("repository", Repository);
            writer.WriteCollectionOfObjectValues<global::Soenneker.GitHub.OpenApiClient.Models.SimpleClassroomUser>("students", Students);
            writer.WriteBoolValue("submitted", Submitted);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
