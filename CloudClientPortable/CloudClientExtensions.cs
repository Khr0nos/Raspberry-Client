
namespace CloudAPI.Rest.Client {
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Extension methods for CloudClient.
    /// </summary>
    public static partial class CloudClientExtensions {
        /// <summary>
        /// Gets all HistoricData Values
        /// </summary>
        /// <remarks>
        /// Returns a JSON array of Historic Data items
        /// </remarks>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static System.Collections.Generic.IList<HistoricData> GetData(this ICloudClient operations) {
            return
                Task.Factory.StartNew(s => GetDataAsync(((ICloudClient) s)), operations,
                    System.Threading.CancellationToken.None, TaskCreationOptions.None,
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
        public static async Task<System.Collections.Generic.IList<HistoricData>> GetDataAsync(
            this ICloudClient operations,
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) {
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
                        System.Threading.CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
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
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) {
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
        public static HistoricData GetData(this ICloudClient operations, int id) {
            return
                Task.Factory.StartNew(s => GetDataAsync(((ICloudClient) s), id), operations,
                    System.Threading.CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task<HistoricData> GetDataAsync(this ICloudClient operations,
            int id,
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) {
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
        public static void PutData(this ICloudClient operations, int id, HistoricData nou = default(HistoricData)) {
            Task.Factory.StartNew(s => PutDataAsync(((ICloudClient) s), id, nou), operations,
                System.Threading.CancellationToken.None, TaskCreationOptions.None,
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
        public static async Task PutDataAsync(this ICloudClient operations,
            int id,
            HistoricData nou = default(HistoricData),
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) {
            await operations.PutDataAsync(id, nou, null, cancellationToken).ConfigureAwait(false);
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
        public static HistoricData DeleteData(this ICloudClient operations, int id) {
            return
                Task.Factory.StartNew(s => DeleteDataAsync(((ICloudClient) s), id), operations,
                    System.Threading.CancellationToken.None, TaskCreationOptions.None,
                    TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
        public static async Task<HistoricData> DeleteDataAsync(this ICloudClient operations,
            int id,
            System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) {
            using (var _result = await operations.DeleteDataAsync(id, null, cancellationToken).ConfigureAwait(false)) {
                return _result.Body;
            }
        }
    }
}
