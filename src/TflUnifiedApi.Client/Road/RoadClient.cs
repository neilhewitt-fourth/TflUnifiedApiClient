using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class RoadClient : ApiClientBase
    {
        /// <summary>Gets all roads managed by TfL</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<IEnumerable<RoadCorridor>> GetAllAsync()
        {
            return GetAllAsync(CancellationToken.None);
        }

        /// <summary>Gets all roads managed by TfL</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<IEnumerable<RoadCorridor>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<RoadCorridor>>(cancellationToken, "/Road");
        }

        /// <summary>Gets the road with the specified id (e.g. A1)</summary>
        /// <param name="IDs">Comma-separated list of road identifiers e.g. "A406, A2" (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<IEnumerable<RoadCorridor>> GetAsync(IEnumerable<string> IDs)
        {
            return GetAsync(IDs, CancellationToken.None);
        }

        /// <summary>Gets the road with the specified id (e.g. A1)</summary>
        /// <param name="IDs">Comma-separated list of road identifiers e.g. "A406, A2" (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<IEnumerable<RoadCorridor>> GetAsync(IEnumerable<string> IDs, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<RoadCorridor>>(cancellationToken, "/Road", ("IDs", IDs));
        }

        /// <summary>Gets the specified roads with the status aggregated over the date range specified, or now until the end of today if no dates are passed.</summary>
        /// <param name="IDs">Comma-separated list of road identifiers e.g. "A406, A2" or use "all" to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<IEnumerable<RoadCorridor>> StatusAsync(IEnumerable<string> IDs, DateTime? dateRangeNullablestartDate, DateTime? dateRangeNullableendDate)
        {
            return StatusAsync(IDs, dateRangeNullablestartDate, dateRangeNullableendDate, CancellationToken.None);
        }

        /// <summary>Gets the specified roads with the status aggregated over the date range specified, or now until the end of today if no dates are passed.</summary>
        /// <param name="IDs">Comma-separated list of road identifiers e.g. "A406, A2" or use "all" to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<IEnumerable<RoadCorridor>> StatusAsync(IEnumerable<string> IDs, DateTime? startDate, DateTime? dateRangeNullableendDate, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<RoadCorridor>>(cancellationToken, "/Road/{IDs}/Status", ("IDs", IDs), ("dateRangeNullableStartDate", startDate), ("dateRangeNullableEndDate", dateRangeNullableendDate)); ;
        }

        /// <summary>Get active disruptions, filtered by road IDs</summary>
        /// <param name="IDs">Comma-separated list of road identifiers e.g. "A406, A2" use all for all to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location, comments and streets</param>
        /// <param name="severities">an optional list of Severity names to filter on (a valid list of severities can be obtained from the /Road/Meta/severities endpoint)</param>
        /// <param name="categories">an optional list of category names to filter on (a valid list of categories can be obtained from the /Road/Meta/categories endpoint)</param>
        /// <param name="closures">Optional, defaults to true. When true, always includes disruptions that have road closures, regardless of the severity filter. When false, the severity filter works as normal.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<IEnumerable<RoadDisruption>> DisruptionAsync(IEnumerable<string> IDs, bool? stripContent, IEnumerable<string> severities, IEnumerable<string> categories, bool? closures)
        {
            return DisruptionAsync(IDs, stripContent, severities, categories, closures, CancellationToken.None);
        }

        /// <summary>Get active disruptions, filtered by road IDs</summary>
        /// <param name="IDs">Comma-separated list of road identifiers e.g. "A406, A2" use all for all to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location, comments and streets</param>
        /// <param name="severities">an optional list of Severity names to filter on (a valid list of severities can be obtained from the /Road/Meta/severities endpoint)</param>
        /// <param name="categories">an optional list of category names to filter on (a valid list of categories can be obtained from the /Road/Meta/categories endpoint)</param>
        /// <param name="closures">Optional, defaults to true. When true, always includes disruptions that have road closures, regardless of the severity filter. When false, the severity filter works as normal.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<IEnumerable<RoadDisruption>> DisruptionAsync(IEnumerable<string> IDs, bool? stripContent, IEnumerable<string> severities, IEnumerable<string> categories, bool? closures, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<RoadDisruption>>(cancellationToken, "/Road/{IDs}/Disruption", ("IDs", IDs), ("stripContent", stripContent), ("severities", severities), ("categories", categories), ("closures", closures));
        }

        /// <summary>Gets a list of disrupted streets. If no date filters are provided, current disruptions are returned.</summary>
        /// <param name="startDate">Optional, the start time to filter on.</param>
        /// <param name="endDate">Optional, The end time to filter on.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<object> DisruptedStreetsAsync(DateTime startDate, DateTime endDate)
        {
            return DisruptedStreetsAsync(startDate, endDate, CancellationToken.None);
        }

        /// <summary>Gets a list of disrupted streets. If no date filters are provided, current disruptions are returned.</summary>
        /// <param name="startDate">Optional, the start time to filter on.</param>
        /// <param name="endDate">Optional, The end time to filter on.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<object> DisruptedStreetsAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            if (startDate == null)
                throw new ArgumentNullException("startDate");

            if (endDate == null)
                throw new ArgumentNullException("endDate");

            return await GetAsync<object>(cancellationToken, "/Road/all/Street/Disruption", ("starDate", startDate), ("endDate", endDate));
        }

        /// <summary>Gets a list of active disruptions filtered by disruption IDs.</summary>
        /// <param name="disruptionIds">Comma-separated list of disruption identifiers to filter by.</param>
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location and comments.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<RoadDisruption> DisruptionByIdAsync(IEnumerable<string> disruptionIds, bool? stripContent)
        {
            return DisruptionByIdAsync(disruptionIds, stripContent, CancellationToken.None);
        }

        /// <summary>Gets a list of active disruptions filtered by disruption IDs.</summary>
        /// <param name="disruptionIds">Comma-separated list of disruption identifiers to filter by.</param>
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location and comments.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<RoadDisruption> DisruptionByIdAsync(IEnumerable<string> disruptionIds, bool? stripContent, CancellationToken cancellationToken)
        {
            if (disruptionIds == null)
                throw new ArgumentNullException("disruptionIds");

            return await GetAsync<RoadDisruption>(cancellationToken, "/Road/all/Disruption/{disruptionIds}", ("disruptionIds", disruptionIds), ("stripContent", stripContent));
        }

        /// <summary>Gets a list of valid RoadDisruption categories</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<IEnumerable<string>> MetaCategoriesAsync()
        {
            return MetaCategoriesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of valid RoadDisruption categories</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<IEnumerable<string>> MetaCategoriesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<string>>(cancellationToken, "/Road/Meta/Categories");
        }

        /// <summary>Gets a list of valid RoadDisruption severity codes</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public Task<IEnumerable<StatusSeverity>> MetaSeveritiesAsync()
        {
            return MetaSeveritiesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of valid RoadDisruption severity codes</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiRoadException">A server side error occurred.</exception>
        public async Task<IEnumerable<StatusSeverity>> MetaSeveritiesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<StatusSeverity>>(cancellationToken, "/Road/Meta/Severities");
        }
    }
}
