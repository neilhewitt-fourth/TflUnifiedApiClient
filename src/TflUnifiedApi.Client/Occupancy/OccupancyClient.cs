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
    public class OccupancyClient : ApiClientBase
    {
        /// <summary>Gets the occupancy for a car park with a given id</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiOccupancyException">A server side error occurred.</exception>
        public Task<CarParkOccupancy> GetAsync(string id)
        {
            return GetAsync(id, CancellationToken.None);
        }

        /// <summary>Gets the occupancy for a car park with a given id</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiOccupancyException">A server side error occurred.</exception>
        public async Task<CarParkOccupancy> GetAsync(string id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<CarParkOccupancy>(cancellationToken, "/Occupancy/CarPark/{id}", ("id", id));
        }

        /// <summary>Gets the occupancy for all car parks that have occupancy data</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiOccupancyException">A server side error occurred.</exception>
        public Task<IEnumerable<CarParkOccupancy>> GetAllAsync()
        {
            return GetAllAsync(CancellationToken.None);
        }

        /// <summary>Gets the occupancy for all car parks that have occupancy data</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiOccupancyException">A server side error occurred.</exception>
        public async Task<IEnumerable<CarParkOccupancy>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<CarParkOccupancy>>(cancellationToken, "/Occupancy/CarPark");
        }
    }
}
