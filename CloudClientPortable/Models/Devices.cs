
using System;
using Newtonsoft.Json;

namespace CloudAPI.Rest.Client.Models
{
    public class Devices
    {
        /// <summary>
        /// Initializes a new instance of the Devices class.
        /// </summary>
        public Devices() { }

        /// <summary>
        /// Initializes a new instance of the Devices class.
        /// </summary>
        public Devices(int iddevice, string deviceName = default(string), int? idauxDeviceType = default(int?), bool? deviceEnabled = default(bool?), bool? deviceConnected = default(bool?), bool? deviceNeedLogin = default(bool?), int? deviceInterval = default(int?), DateTime? deviceCreationDate = default(DateTime?), string deviceUsername = default(string), string devicePassword = default(string), int? iddeviceProtocol = default(int?), string deviceAux = default(string))
        {
            Iddevice = iddevice;
            DeviceName = deviceName;
            IdauxDeviceType = idauxDeviceType;
            DeviceEnabled = deviceEnabled;
            DeviceConnected = deviceConnected;
            DeviceNeedLogin = deviceNeedLogin;
            DeviceInterval = deviceInterval;
            DeviceCreationDate = deviceCreationDate;
            DeviceUsername = deviceUsername;
            DevicePassword = devicePassword;
            IddeviceProtocol = iddeviceProtocol;
            DeviceAux = deviceAux;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iddevice")]
        public int Iddevice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idauxDeviceType")]
        public int? IdauxDeviceType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceEnabled")]
        public bool? DeviceEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceConnected")]
        public bool? DeviceConnected { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceNeedLogin")]
        public bool? DeviceNeedLogin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceInterval")]
        public int? DeviceInterval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceCreationDate")]
        public DateTime? DeviceCreationDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deviceUsername")]
        public string DeviceUsername { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devicePassword")]
        public string DevicePassword { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iddeviceProtocol")]
        public int? IddeviceProtocol { get; set; }

        /// <summary>
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
