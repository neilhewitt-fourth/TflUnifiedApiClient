using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class BikePointClient : ApiClientBase
    {
        /// <summary>Gets all bike point locations. The Place object has an addtionalProperties array which contains the nbBikes, nbDocks and nbSpaces
        ///             numbers which give the status of the BikePoint. A mismatch in these numbers i.e. nbDocks - (nbBikes + nbSpaces) != 0 indicates broken docks.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiBikePointException">A server side error occurred.</exception>
        public Task<ObservableCollection<Place>> GetAllAsync()
        {
            return GetAllAsync(CancellationToken.None);
        }

        /// <summary>Gets all bike point locations. The Place object has an addtionalProperties array which contains the nbBikes, nbDocks and nbSpaces
        ///             numbers which give the status of the BikePoint. A mismatch in these numbers i.e. nbDocks - (nbBikes + nbSpaces) != 0 indicates broken docks.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiBikePointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Place>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<Place>>(cancellationToken, "/BikePoint");
        }

        /// <summary>Gets the bike point with the given id.</summary>
        /// <param name="id">A bike point id (a list of ids can be obtained from the above BikePoint call)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiBikePointException">A server side error occurred.</exception>
        public Task<Place> GetAsync(string id)
        {
            return GetAsync(id, CancellationToken.None);
        }

        /// <summary>Gets the bike point with the given id.</summary>
        /// <param name="id">A bike point id (a list of ids can be obtained from the above BikePoint call)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiBikePointException">A server side error occurred.</exception>
        public async Task<Place> GetAsync(string id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<Place>(cancellationToken, "/BikePoint/{id}", ("id", id));
        }

        /// <summary>Search for bike stations by their name, a bike point's name often contains information about the name of the street
        ///             or nearby landmarks, for example. Note that the search result does not contain the PlaceProperties i.e. the status
        ///             or occupancy of the BikePoint, to get that information you should retrieve the BikePoint by its id on /BikePoint/id.</summary>
        /// <param name="query">The search term e.g. "St. James"</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiBikePointException">A server side error occurred.</exception>
        public Task<ObservableCollection<Place>> SearchAsync(string query)
        {
            return SearchAsync(query, CancellationToken.None);
        }

        /// <summary>Search for bike stations by their name, a bike point's name often contains information about the name of the street
        ///             or nearby landmarks, for example. Note that the search result does not contain the PlaceProperties i.e. the status
        ///             or occupancy of the BikePoint, to get that information you should retrieve the BikePoint by its id on /BikePoint/id.</summary>
        /// <param name="query">The search term e.g. "St. James"</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiBikePointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Place>> SearchAsync(string query, CancellationToken cancellationToken)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            return await GetAsync<ObservableCollection<Place>>(cancellationToken, "/BikePoint/Search", ("query", query));
        }
    }
}
