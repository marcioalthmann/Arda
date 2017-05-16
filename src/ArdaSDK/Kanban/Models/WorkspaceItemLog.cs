// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ArdaSDK.Kanban.Models
{
    using ArdaSDK.Kanban;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WorkspaceItemLog
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceItemLog class.
        /// </summary>
        public WorkspaceItemLog()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceItemLog class.
        /// </summary>
        public WorkspaceItemLog(System.Guid? id = default(System.Guid?), string text = default(string), string createdBy = default(string), System.DateTime? createdDate = default(System.DateTime?), WorkspaceItemLogProperties properties = default(WorkspaceItemLogProperties))
        {
            Id = id;
            Text = text;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CreatedDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Properties")]
        public WorkspaceItemLogProperties Properties { get; set; }

    }
}
