using System;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models {
    /// <summary>
    /// Model class for Devices table entries
    /// </summary>
    public class Devices {
        /// <summary>
        /// Initializes a new instance of the Devices class.
        /// </summary>
        public Devices(string deviceName = "",
            int deviceType = 1,
            bool enabled = false,
            bool connected = false,
            bool needLogin = false,
            int interval = 1000,
            int iddevice = 0,
            DateTime? creationDate = null,
            string username = "",
            string password = "",
            int deviceProtocol = 1,
            string deviceAux = null) {
            Iddevice = iddevice;
            DeviceName = deviceName;
            IdauxDeviceType = deviceType;
            DeviceEnabled = enabled;
            DeviceConnected = connected;
            DeviceNeedLogin = needLogin;
            DeviceInterval = interval;
            DeviceCreationDate = creationDate;
            DeviceUsername = username;
            DevicePassword = password;
            IddeviceProtocol = deviceProtocol;
            DeviceAux = deviceAux;
        }

        /// <summary>
        /// Device identifier
        /// </summary>
        [JsonProperty(PropertyName = "iddevice")]
        public int Iddevice { get; set; }

        /// <summary>
        /// Device Name
        /// </summary>
        [JsonProperty(PropertyName = "deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// Device Type identifier
        /// </summary>
        [JsonProperty(PropertyName = "idauxDeviceType")]
        public int IdauxDeviceType { get; set; }

        /// <summary>
        /// Boolean to indicate state of activation of device
        /// </summary>
        [JsonProperty(PropertyName = "deviceEnabled")]
        public bool DeviceEnabled { get; set; }

        /// <summary>
        /// Boolean to indicate state of connection of device
        /// </summary>
        [JsonProperty(PropertyName = "deviceConnected")]
        public bool DeviceConnected { get; set; }

        /// <summary>
        /// Boolean to indicate use of login of device
        /// </summary>
        [JsonProperty(PropertyName = "deviceNeedLogin")]
        public bool DeviceNeedLogin { get; set; }

        /// <summary>
        /// Interval of data sending
        /// </summary>
        [JsonProperty(PropertyName = "deviceInterval")]
        public int DeviceInterval { get; set; }

        /// <summary>
        /// Date and time of device creation
        /// </summary>
        [JsonProperty(PropertyName = "deviceCreationDate")]
        public DateTime? DeviceCreationDate { get; set; }

        /// <summary>
        /// Username for login
        /// </summary>
        [JsonProperty(PropertyName = "deviceUsername")]
        public string DeviceUsername { get; set; }

        /// <summary>
        /// Password for login
        /// </summary>
        [JsonProperty(PropertyName = "devicePassword")]
        public string DevicePassword { get; set; }

        /// <summary>
        /// Device Protocol identifier
        /// </summary>
        [JsonProperty(PropertyName = "iddeviceProtocol")]
        public int IddeviceProtocol { get; set; }

        /// <summary>
        /// Auxiliar field. Optional
        /// </summary>
        [JsonProperty(PropertyName = "deviceAux")]
        public string DeviceAux { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
