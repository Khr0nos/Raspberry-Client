
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    public class JsonPatchDocumentHistoricData
    {
        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentHistoricData
        /// class.
        /// </summary>
        public JsonPatchDocumentHistoricData() { }

        /// <summary>
        /// Initializes a new instance of the JsonPatchDocumentHistoricData
        /// class.
        /// </summary>
        public JsonPatchDocumentHistoricData(IList<OperationHistoricData> operations = default(IList<OperationHistoricData>))
        {
            Operations = operations;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<OperationHistoricData> Operations { get; private set; }

    }
}
