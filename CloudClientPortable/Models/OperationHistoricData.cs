
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    public class OperationHistoricData
    {
        /// <summary>
        /// Initializes a new instance of the OperationHistoricData class.
        /// </summary>
        public OperationHistoricData() { }

        /// <summary>
        /// Initializes a new instance of the OperationHistoricData class.
        /// </summary>
        public OperationHistoricData(object value = default(object), string path = default(string), string op = default(string), string fromProperty = default(string))
        {
            Value = value;
            Path = path;
            Op = op;
            FromProperty = fromProperty;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "op")]
        public string Op { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public string FromProperty { get; set; }

    }
}
