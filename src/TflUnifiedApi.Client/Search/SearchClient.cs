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
    public class SearchClient : ApiClientBase
    {
        /// <summary>Search the site for occurrences of the query string. The maximum number of results returned is equal to the maximum page size
        ///             of 100. To return subsequent pages, use the paginated overload.</summary>
        /// <param name="query">The search query</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public Task<SearchResponse> GetAsync(string query)
        {
            return GetAsync(query, CancellationToken.None);
        }

        /// <summary>Search the site for occurrences of the query string. The maximum number of results returned is equal to the maximum page size
        ///             of 100. To return subsequent pages, use the paginated overload.</summary>
        /// <param name="query">The search query</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public async Task<SearchResponse> GetAsync(string query, CancellationToken cancellationToken)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            return await GetAsync<SearchResponse>(cancellationToken, "/Search", ("query", query));
        }

        /// <summary>Searches the bus schedules folder on S3 for a given bus number.</summary>
        /// <param name="query">The search query</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public Task<SearchResponse> BusSchedulesAsync(string query)
        {
            return BusSchedulesAsync(query, CancellationToken.None);
        }

        /// <summary>Searches the bus schedules folder on S3 for a given bus number.</summary>
        /// <param name="query">The search query</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public async Task<SearchResponse> BusSchedulesAsync(string query, CancellationToken cancellationToken)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            return await GetAsync<SearchResponse>(cancellationToken, "/Search/BusSchedules", ("query", query));
        }

        /// <summary>Gets the available searchProvider names.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public Task<IEnumerable<string>> MetaSearchProvidersAsync()
        {
            return MetaSearchProvidersAsync(CancellationToken.None);
        }

        /// <summary>Gets the available searchProvider names.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public async Task<IEnumerable<string>> MetaSearchProvidersAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<string>>(cancellationToken, "/Search/Meta/SearchProviders");
        }

        /// <summary>Gets the available search categories.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public Task<IEnumerable<string>> MetaCategoriesAsync()
        {
            return MetaCategoriesAsync(CancellationToken.None);
        }

        /// <summary>Gets the available search categories.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public async Task<IEnumerable<string>> MetaCategoriesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<string>>(cancellationToken, "/Search/Meta/Categories");
        }

        /// <summary>Gets the available sorting options.</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public Task<IEnumerable<string>> MetaSortsAsync()
        {
            return MetaSortsAsync(CancellationToken.None);
        }

        /// <summary>Gets the available sorting options.</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiSearchException">A server side error occurred.</exception>
        public async Task<IEnumerable<string>> MetaSortsAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<string>>(cancellationToken, "/Search/Meta/Sorts");
        }
    }
}
