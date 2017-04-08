
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    /// <summary>
    /// Partial update of HistoricData
    /// </summary>
    public class OperationHistoricData
    {
        /// <summary>
        /// Initializes a new instance of the OperationHistoricData class.
        /// </summary>
        public OperationHistoricData() { }

        /// <summary>
        /// Initializes a new instance of the OperationHistoricData class with initial values
        /// </summary>
        public OperationHistoricData(object value = default(object), string path = default(string), string op = default(string), string fromProperty = default(string))
        {
            Value = value;
            Path = path;
            Op = op;
            FromProperty = fromProperty;
        }

        /// <summary>
        /// New value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Field to modify
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Operation to perform on field. Should be "replace"
        /// </summary>
        [JsonProperty(PropertyName = "op")]
        public string Op { get; set; }

        [JsonProperty(PropertyName = "from")]
        public string FromProperty { get; set; }

    }
}
