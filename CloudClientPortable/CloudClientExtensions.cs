using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CloudAPI.Rest.Client.Models;

namespace CloudAPI.Rest.Client {
    /// <summary>
    /// Extension methods for CloudClient.
    /// </summary>
    public static class CloudClientExtensions {
        /// <summary>
        /// Gets all HistoricData Values
        /// </summary>
        /// <remarks>
        /// Returns a JSON array of Historic Data items
        /// </remarks>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<HistoricData> GetData(this ICloudClient operations) {
            return
                Task.Factory.StartNew(s => GetDataAsync(((ICloudClient) s)), operations,
                    CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all HistoricData Values
        /// </summary>
        /// <remarks>
        /// Returns a JSON array of Historic Data items
        /// </remarks>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<HistoricData>> GetDataAsync(
            this ICloudClient operations,
            CancellationToken cancellationToken = default(CancellationToken)) {
            using (var _result = await operations.GetDataAsync(null, cancellationToken).ConfigureAwait(false)) {
                return _result.Body;
            }
        }

        /// <summary>
        /// Adds new HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nou'>
        /// new HistoricData to be added
        /// </param>
        public static object PostData(this ICloudClient operations, HistoricData nou = default(HistoricData)) {
            return
                Task.Factory.StartNew(s => ((ICloudClient) s).PostDataAsync(nou), operations,
                        CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                    .Unwrap()
                    .GetAwaiter()
                    .GetResult();
        }

        /// <summary>
        /// Adds new HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nou'>
        /// new HistoricData to be added
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> PostDataAsync(this ICloudClient operations,
            HistoricData nou = default(HistoricData),
            CancellationToken cancellationToken = default(CancellationToken)) {
            using (var _result = await operations.PostDataAsync(nou, null, cancellationToken).ConfigureAwait(false)) {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets specific HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// HistoricData identifier
        /// </param>
        public static object GetData(this ICloudClient operations, int id) {
            return
                Task.Factory.StartNew(s => ((ICloudClient) s).GetDataAsync(id), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets specific HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// HistoricData identifier
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> GetDataAsync(this ICloudClient operations,
            int id,
            CancellationToken cancellationToken = default(CancellationToken)) {
            using (var _result = await operations.GetDataAsync(id, null, cancellationToken).ConfigureAwait(false)) {
                return _result.Body;
            }
        }

        /// <summary>
        /// Updates existing HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// HistoricData identifier
        /// </param>
        /// <param name='nou'>
        /// HistoricData to be updated
        /// </param>
        public static object PutData(this ICloudClient operations, int id, HistoricData nou = default(HistoricData)) {
            return Task.Factory.StartNew(s => PutDataAsync(((ICloudClient) s), id, nou), operations,
                CancellationToken.None, TaskCreationOptions.None,
                TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates existing HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// HistoricData identifier
        /// </param>
        /// <param name='nou'>
        /// HistoricData to be updated
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> PutDataAsync(this ICloudClient operations,
            int id,
            HistoricData nou = default(HistoricData),
            CancellationToken cancellationToken = default(CancellationToken)) {
            using (var _result = await operations.PutDataAsync(id, nou, null, cancellationToken).ConfigureAwait(false)) {
                return _result;
            }
        }

        /// <summary>
        /// Deletes specific HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// HistoricData identifier
        /// </param>
        public static object DeleteData(this ICloudClient operations, int id) {
            return
                Task.Factory.StartNew(s => ((ICloudClient) s).DeleteDataAsync(id), operations, CancellationToken.None,
                    TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes specific HistoricData
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// HistoricData identifier
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> DeleteDataAsync(this ICloudClient operations,
            int id,
            CancellationToken cancellationToken = default(CancellationToken)) {
            using (var _result = await operations.DeleteDataAsync(id, null, cancellationToken).ConfigureAwait(false)) {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets all devices definitions
        /// </summary>
        /// <remarks>
        /// Returns a JSON array of Devices
        /// </remarks>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static IList<Devices> GetDevices(this ICloudClient operations)
        {
            return Task.Factory.StartNew(s => GetDevicesAsync(((ICloudClient)s)), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets all devices definitions
        /// </summary>
        /// <remarks>
        /// Returns a JSON array of Devices
        /// </remarks>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<IList<Devices>> GetDevicesAsync(this ICloudClient operations, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetDevicesAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Adds new Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nou'>
        /// new logic Device definition to be added
        /// </param>
        public static object PostDevice(this ICloudClient operations, Devices nou = default(Devices))
        {
            return Task.Factory.StartNew(s => ((ICloudClient)s).PostDeviceAsync(nou), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Adds new Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nou'>
        /// new logic Device definition to be added
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> PostDeviceAsync(this ICloudClient operations, Devices nou = default(Devices), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PostDeviceAsync(nou, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets specific Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        public static object GetDevices(this ICloudClient operations, int id)
        {
            return Task.Factory.StartNew(s => GetDeviceAsync(((ICloudClient)s), id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets specific Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> GetDeviceAsync(this ICloudClient operations, int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetDeviceAsync(id, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Updates existing Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        /// <param name='nou'>
        /// Device to be updated
        /// </param>
        public static object PutDevice(this ICloudClient operations, int id, Devices nou = default(Devices))
        {
            return Task.Factory.StartNew(s => ((ICloudClient)s).PutDeviceAsync(id, nou), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates existing Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        /// <param name='nou'>
        /// Device to be updated
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> PutDeviceAsync(this ICloudClient operations, int id, Devices nou = default(Devices), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PutDeviceAsync(id, nou, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Deletes specific Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        public static object DeleteDevice(this ICloudClient operations, int id)
        {
            return Task.Factory.StartNew(s => ((ICloudClient)s).DeleteDeviceAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes specific Device
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> DeleteDeviceAsync(this ICloudClient operations, int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.DeleteDeviceAsync(id, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Updates some Device information
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        /// <param name='patch'>
        /// Device updated information
        /// </param>
        public static object PatchDevice(this ICloudClient operations, int id, JsonPatchDocumentDevices patch = default(JsonPatchDocumentDevices))
        {
            return Task.Factory.StartNew(s => PatchDeviceAsync(((ICloudClient)s), id, patch), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Updates some Device information
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// Device identifier
        /// </param>
        /// <param name='patch'>
        /// Device updated information
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<object> PatchDeviceAsync(this ICloudClient operations, int id, JsonPatchDocumentDevices patch = default(JsonPatchDocumentDevices), CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.PatchDeviceAsync(id, patch, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
