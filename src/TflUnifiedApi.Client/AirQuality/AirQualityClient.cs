using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class AirQualityClient : ApiClientBase
    {
        /// <summary>Gets air quality data feed</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiAirQualityException">A server side error occurred.</exception>
        public Task<object> GetAsync()
        {
            return GetAsync(CancellationToken.None);
        }

        /// <summary>Gets air quality data feed</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiAirQualityException">A server side error occurred.</exception>
        public async Task<object> GetAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<object>(cancellationToken, "/AirQuality");
        }
    }
}
