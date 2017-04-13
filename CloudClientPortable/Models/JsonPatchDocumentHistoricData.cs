
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    /// <summary>
    /// Model class for HistoricData partial updates via Patch requests
    /// </summary>
    public class JsonPatchDocumentHistoricData
    {
        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentHistoricData
        /// class.
        /// </summary>
        public JsonPatchDocumentHistoricData() { }

        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentHistoricData
        /// class with initial list
        /// </summary>
        public JsonPatchDocumentHistoricData(IList<OperationHistoricData> operations = default(IList<OperationHistoricData>))
        {
            Operations = operations;
        }

        /// <summary>
        /// List of partial updates of HistoricData
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<OperationHistoricData> Operations { get; private set; }

    }
}
