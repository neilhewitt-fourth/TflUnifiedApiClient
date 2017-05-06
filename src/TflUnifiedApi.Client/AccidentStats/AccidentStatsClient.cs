using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class AccidentStatsClient : ApiClientBase
    {
        /// <summary>Gets all accident details for accidents occuring in the specified year</summary>
        /// <param name="year">The year for which to filter the accidents on.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiAccidentStatsException">A server side error occurred.</exception>
        public Task<ObservableCollection<AccidentDetail>> GetAsync(int year)
        {
            return GetAsync(year, CancellationToken.None);
        }

        /// <summary>Gets all accident details for accidents occuring in the specified year</summary>
        /// <param name="year">The year for which to filter the accidents on.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiAccidentStatsException">A server side error occurred.</exception>
        public async Task<ObservableCollection<AccidentDetail>> GetAsync(int year, CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<AccidentDetail>>(cancellationToken, "/AccidentStats/{year}", ("year", year));
        }
    }
}
