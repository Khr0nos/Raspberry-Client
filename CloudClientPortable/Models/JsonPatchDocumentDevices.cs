
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    /// <summary>
    /// Model class for Devices partial updates via Patch requests
    /// </summary>
    public class JsonPatchDocumentDevices
    {
        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentDevices class.
        /// </summary>
        public JsonPatchDocumentDevices() { }

        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentDevices class with initial list
        /// </summary>
        public JsonPatchDocumentDevices(IList<OperationDevices> operations = default(IList<OperationDevices>))
        {
            Operations = operations;
        }

        /// <summary>
        /// List of partial updates of Devices
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<OperationDevices> Operations { get; private set; }

    }
}
