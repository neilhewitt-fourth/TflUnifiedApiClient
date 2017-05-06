using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class VehicleClient : ApiClientBase
    {
        /// <summary>Gets the predictions for a given list of vehicle Id's.</summary>
        /// <param name="ids">A comma-separated list of vehicle ids e.g. LX58CFV,LX11AZB,LX58CFE. Max approx. 25 ids.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiVehicleException">A server side error occurred.</exception>
        public Task<ObservableCollection<Prediction>> GetAsync(IEnumerable<string> ids)
        {
            return GetAsync(ids, CancellationToken.None);
        }

        /// <summary>Gets the predictions for a given list of vehicle Id's.</summary>
        /// <param name="ids">A comma-separated list of vehicle ids e.g. LX58CFV,LX11AZB,LX58CFE. Max approx. 25 ids.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiVehicleException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Prediction>> GetAsync(IEnumerable<string> ids, CancellationToken cancellationToken)
        {
            if (ids == null)
                throw new ArgumentNullException("ids");

            return await GetAsync<ObservableCollection<Prediction>>(cancellationToken, "/Vehicle/{ids}/Arrivals", ("ids", ids));
        }

        /// <summary>Gets the Emissions Surcharge compliance for the Vehicle</summary>
        /// <param name="vrm">The Vehicle Registration Mark</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiVehicleException">A server side error occurred.</exception>
        public Task<EmissionsSurchargeVehicle> GetVehicleAsync(string vrm)
        {
            return GetVehicleAsync(vrm, CancellationToken.None);
        }

        /// <summary>Gets the Emissions Surcharge compliance for the Vehicle</summary>
        /// <param name="vrm">The Vehicle Registration Mark</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiVehicleException">A server side error occurred.</exception>
        public async Task<EmissionsSurchargeVehicle> GetVehicleAsync(string vrm, CancellationToken cancellationToken)
        {
            if (vrm == null)
                throw new ArgumentNullException("vrm");

            return await GetAsync<EmissionsSurchargeVehicle>(cancellationToken, "/Vehicle/EmissionSurcharge", ("vrm", vrm));
        }
    }
}
