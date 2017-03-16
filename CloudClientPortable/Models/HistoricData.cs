using System;
using Microsoft.Rest;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models {
    public class HistoricData {
        /// <summary>
        /// Initializes a new instance of the HistoricData class.
        /// </summary>
        public HistoricData(int device,
            string dataValue,
            int dataType,
            int idhistoricData = 0,
            DateTime? histDataDate = null,
            bool histDataToDevice = false,
            bool histDataAck = false,
            string histDataAux = null) {
            IdhistoricData = idhistoricData;
            Iddevice = device;
            HistDataDate = histDataDate;
            HistDataValue = dataValue;
            IddataType = dataType;
            HistDataToDevice = histDataToDevice;
            HistDataAck = histDataAck;
            HistDataAux = histDataAux;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idhistoricData")]
        public int IdhistoricData { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iddevice")]
        public int Iddevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "histDataDate")]
        public DateTime? HistDataDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "histDataValue")]
        public string HistDataValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iddataType")]
        public int IddataType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "histDataToDevice")]
        public bool HistDataToDevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "histDataAck")]
        public bool HistDataAck { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "histDataAux")]
        public string HistDataAux { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate() {
            if (HistDataValue == null) {
                throw new ValidationException(ValidationRules.CannotBeNull,
                    "HistDataValue");
            }
        }
    }
}
