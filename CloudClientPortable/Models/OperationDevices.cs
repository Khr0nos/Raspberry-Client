
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    public class OperationDevices
    {
        /// <summary>
        /// Initializes a new instance of the OperationDevices class.
        /// </summary>
        public OperationDevices() { }

        /// <summary>
        /// Initializes a new instance of the OperationDevices class.
        /// </summary>
        public OperationDevices(object value = default(object), string path = default(string), string op = default(string), string fromProperty = default(string))
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
