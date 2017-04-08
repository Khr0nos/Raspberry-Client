using System;
using Microsoft.Rest;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models {
    /// <summary>
    /// Model class for HistoricData table
    /// </summary>
    public class HistoricData {
        /// <summary>
        /// Initializes a new instance of the HistoricData class.
        /// </summary>
        public HistoricData(int device,
            string dataValue,
            int dataType,
            int? idhistoricData = null,
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
        /// Data identifier
        /// </summary>
        [JsonProperty(PropertyName = "idhistoricData")]
        public int? IdhistoricData { get; set; }

        /// <summary>
        /// Device identifier.
        /// This identifier marks which device sent this data
        /// </summary>
        [JsonProperty(PropertyName = "iddevice")]
        public int Iddevice { get; set; }

        /// <summary>
        /// Date and time of data creation
        /// </summary>
        [JsonProperty(PropertyName = "histDataDate")]
        public DateTime? HistDataDate { get; set; }

        /// <summary>
        /// Data value
        /// </summary>
        [JsonProperty(PropertyName = "histDataValue")]
        public string HistDataValue { get; set; }

        /// <summary>
        /// Data type identifier
        /// </summary>
        [JsonProperty(PropertyName = "iddataType")]
        public int IddataType { get; set; }

        /// <summary>
        /// Boolean to indicate if it's some data to be sent to device
        /// </summary>
        [JsonProperty(PropertyName = "histDataToDevice")]
        public bool HistDataToDevice { get; set; }

        /// <summary>
        /// Boolean to indicate confirmation from the device.
        /// This field marks if some data sent to the device has been confirmed
        /// </summary>
        [JsonProperty(PropertyName = "histDataAck")]
        public bool HistDataAck { get; set; }

        /// <summary>
        /// Auxiliar field. Optional
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
