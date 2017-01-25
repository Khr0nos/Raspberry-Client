
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    public class JsonPatchDocumentDevices
    {
        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentDevices class.
        /// </summary>
        public JsonPatchDocumentDevices() { }

        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentDevices class.
        /// </summary>
        public JsonPatchDocumentDevices(IList<OperationDevices> operations = default(IList<OperationDevices>))
        {
            Operations = operations;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<OperationDevices> Operations { get; private set; }

    }
}
