using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class ModeClient : ApiClientBase
    {
        /// <summary>Returns the service type active for a mode.
        ///             Currently only supports tube</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiModeException">A server side error occurred.</exception>
        public Task<IEnumerable<ActiveServiceType>> GetActiveServiceTypesAsync()
        {
            return GetActiveServiceTypesAsync(CancellationToken.None);
        }

        /// <summary>Returns the service type active for a mode.
        ///             Currently only supports tube</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiModeException">A server side error occurred.</exception>
        public async Task<IEnumerable<ActiveServiceType>> GetActiveServiceTypesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<ActiveServiceType>>(cancellationToken, "/Mode/ActiveServiceTypes");
        }

        /// <summary>Gets the next arrival predictions for all stops of a given mode</summary>
        /// <param name="mode">A mode name e.g. tube, dlr</param>
        /// <param name="count">A number of arrivals to return for each stop, -1 to return all available.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiModeException">A server side error occurred.</exception>
        public Task<IEnumerable<Prediction>> ArrivalsAsync(string mode, int? count)
        {
            return ArrivalsAsync(mode, count, CancellationToken.None);
        }

        /// <summary>Gets the next arrival predictions for all stops of a given mode</summary>
        /// <param name="mode">A mode name e.g. tube, dlr</param>
        /// <param name="count">A number of arrivals to return for each stop, -1 to return all available.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiModeException">A server side error occurred.</exception>
        public async Task<IEnumerable<Prediction>> ArrivalsAsync(string mode, int? count, CancellationToken cancellationToken)
        {
            if (mode == null)
                throw new ArgumentNullException("mode");

            return await GetAsync<IEnumerable<Prediction>>(cancellationToken, "/Mode/{mode}/Arrivals", ("mode", mode));
        }
    }
}
