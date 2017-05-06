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
    public class StopPointClient : ApiClientBase
    {
        /// <summary>Gets the list of available StopPoint additional information categories</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPointCategory>> MetaCategoriesAsync()
        {
            return MetaCategoriesAsync(CancellationToken.None);
        }

        /// <summary>Gets the list of available StopPoint additional information categories</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPointCategory>> MetaCategoriesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<StopPointCategory>>(cancellationToken, "/StopPoint/Meta/Categories");
        }

        /// <summary>Gets the list of available StopPoint types</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<string>> MetaStopTypesAsync()
        {
            return MetaStopTypesAsync(CancellationToken.None);
        }

        /// <summary>Gets the list of available StopPoint types</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<string>> MetaStopTypesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<string>>(cancellationToken, "/StopPoint/Meta/StopTypes");
        }

        /// <summary>Gets the list of available StopPoint modes</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<Mode>> MetaModesAsync()
        {
            return MetaModesAsync(CancellationToken.None);
        }

        /// <summary>Gets the list of available StopPoint modes</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Mode>> MetaModesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<ObservableCollection<Mode>>(cancellationToken, "/StopPoint/Meta/Modes");
        }

        /// <summary>Gets a list of StopPoints corresponding to the given list of stop ids.</summary>
        /// <param name="ids">A comma-separated list of stop point ids (station naptan code e.g. 940GZZLUASL). Max. approx. 20 ids.
        ///             You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param>
        /// <param name="includeCrowdingData">Include the crowding data (static). To Filter further use: /StopPoint/{ids}/Crowding/{line}</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPoint>> GetAsync(IEnumerable<string> ids, bool? includeCrowdingData)
        {
            return GetAsync(ids, includeCrowdingData, CancellationToken.None);
        }

        /// <summary>Gets a list of StopPoints corresponding to the given list of stop ids.</summary>
        /// <param name="ids">A comma-separated list of stop point ids (station naptan code e.g. 940GZZLUASL). Max. approx. 20 ids.
        ///             You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param>
        /// <param name="includeCrowdingData">Include the crowding data (static). To Filter further use: /StopPoint/{ids}/Crowding/{line}</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPoint>> GetAsync(IEnumerable<string> ids, bool? includeCrowdingData, CancellationToken cancellationToken)
        {
            if (ids == null)
                throw new ArgumentNullException("ids");

            return await GetAsync<ObservableCollection<StopPoint>>(cancellationToken, "/StopPoint/{ids}", ("ids", ids));
        }

        /// <summary>Gets all the Crowding data (static) for the StopPointId, plus crowding data for a given line and optionally a particular direction.</summary>
        /// <param name="id">The Naptan id of the stop</param>
        /// <param name="line">A particular line e.g. victoria, circle, northern etc.</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPoint>> CrowdingAsync(string id, string line, Direction direction)
        {
            return CrowdingAsync(id, line, direction, CancellationToken.None);
        }

        /// <summary>Gets all the Crowding data (static) for the StopPointId, plus crowding data for a given line and optionally a particular direction.</summary>
        /// <param name="id">The Naptan id of the stop</param>
        /// <param name="line">A particular line e.g. victoria, circle, northern etc.</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPoint>> CrowdingAsync(string id, string line, Direction direction, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            if (line == null)
                throw new ArgumentNullException("line");

            return await GetAsync<ObservableCollection<StopPoint>>(cancellationToken, "/StopPoint/{id}/Crowding/{line}", ("id", id), ("line", line));
        }

        /// <summary>Gets all stop points of a given type</summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx. 12 types. 
        ///             A list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPoint>> GetByTypeAsync(IEnumerable<string> types)
        {
            return GetByTypeAsync(types, CancellationToken.None);
        }

        /// <summary>Gets all stop points of a given type</summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx. 12 types. 
        ///             A list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPoint>> GetByTypeAsync(IEnumerable<string> types, CancellationToken cancellationToken)
        {
            if (types == null)
                throw new ArgumentNullException("types");

            return await GetAsync<ObservableCollection<StopPoint>>(cancellationToken, "/StopPoint/Type/{types}", ("types", types));
        }

        /// <summary>Gets the service types for a given stoppoint</summary>
        /// <param name="id">The Naptan id of the stop</param>
        /// <param name="lineIds">The lines which contain the given Naptan id (all lines relevant to the given stoppoint if empty)</param>
        /// <param name="modes">The modes which the lines are relevant to (all if empty)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<LineServiceType>> GetServiceTypesAsync(string id, IEnumerable<string> lineIds, IEnumerable<string> modes)
        {
            return GetServiceTypesAsync(id, lineIds, modes, CancellationToken.None);
        }

        /// <summary>Gets the service types for a given stoppoint</summary>
        /// <param name="id">The Naptan id of the stop</param>
        /// <param name="lineIds">The lines which contain the given Naptan id (all lines relevant to the given stoppoint if empty)</param>
        /// <param name="modes">The modes which the lines are relevant to (all if empty)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<LineServiceType>> GetServiceTypesAsync(string id, IEnumerable<string> lineIds, IEnumerable<string> modes, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<ObservableCollection<LineServiceType>>(cancellationToken, "/StopPoint/ServiceTypes", ("id", id), ("lineIds", lineIds), ("modes", modes));
        }

        /// <summary>Gets the list of arrival predictions for the given stop point id</summary>
        /// <param name="id">A StopPoint id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<Prediction>> ArrivalsAsync(string id)
        {
            return ArrivalsAsync(id, CancellationToken.None);
        }

        /// <summary>Gets the list of arrival predictions for the given stop point id</summary>
        /// <param name="id">A StopPoint id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Prediction>> ArrivalsAsync(string id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<ObservableCollection<Prediction>>(cancellationToken, "/StopPoint/{id}/Arrivals", ("id", id));
        }

        /// <summary>Gets Stopoints that are reachable from a station/line combination.</summary>
        /// <param name="id">The id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name) of the stop point to filter by</param>
        /// <param name="lineId">Line id of the line to filter by (e.g. victoria)</param>
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPoint>> ReachableFromAsync(string id, string lineId, IEnumerable<ServiceType> serviceTypes)
        {
            return ReachableFromAsync(id, lineId, serviceTypes, CancellationToken.None);
        }

        /// <summary>Gets Stopoints that are reachable from a station/line combination.</summary>
        /// <param name="id">The id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name) of the stop point to filter by</param>
        /// <param name="lineId">Line id of the line to filter by (e.g. victoria)</param>
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPoint>> ReachableFromAsync(string id, string lineId, IEnumerable<ServiceType> serviceTypes, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            if (lineId == null)
                throw new ArgumentNullException("lineId");

            return await GetAsync<ObservableCollection<StopPoint>>(cancellationToken, "/StopPoint/{id}/CanReachOnLine/{lineId}", ("id", id), ("lineId", lineId));
        }

        /// <summary>Returns the route sections for all the lines that service the given stop point ids</summary>
        /// <param name="id">A stop point id (station naptan codes e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<StopPointRouteSection>> RouteAsync(string id, IEnumerable<ServiceType> serviceTypes)
        {
            return RouteAsync(id, serviceTypes, CancellationToken.None);
        }

        /// <summary>Returns the route sections for all the lines that service the given stop point ids</summary>
        /// <param name="id">A stop point id (station naptan codes e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<StopPointRouteSection>> RouteAsync(string id, IEnumerable<ServiceType> serviceTypes, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<ObservableCollection<StopPointRouteSection>>(cancellationToken, "/StopPoint/{id}/Route", ("id", id), ("serviceTypes", serviceTypes));
        }

        /// <summary>Gets a distinct list of disrupted stop points for the given modes</summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<DisruptedPoint>> DisruptionByModeAsync(IEnumerable<string> modes, bool? includeRouteBlockedStops)
        {
            return DisruptionByModeAsync(modes, includeRouteBlockedStops, CancellationToken.None);
        }

        /// <summary>Gets a distinct list of disrupted stop points for the given modes</summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<DisruptedPoint>> DisruptionByModeAsync(IEnumerable<string> modes, bool? includeRouteBlockedStops, CancellationToken cancellationToken)
        {
            if (modes == null)
                throw new ArgumentNullException("modes");

            return await GetAsync<ObservableCollection<DisruptedPoint>>(cancellationToken, "/StopPoint/Mode/{modes}/Disruption", ("modes", modes), ("includeRouteBlockedStops", includeRouteBlockedStops));
        }

        /// <summary>Gets all disruptions for the specified StopPointId, plus disruptions for any child Naptan records it may have.</summary>
        /// <param name="ids">A comma-seperated list of stop point ids. Max. approx. 20 ids.
        ///             You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param>
        /// <param name="getFamily">Specify true to return disruptions for entire family, or false to return disruptions for just this stop point. Defaults to false.</param>
        /// <param name="flattenResponse">Specify true to associate all disruptions with parent stop point. (Only applicable when getFamily is true).</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<DisruptedPoint>> DisruptionAsync(IEnumerable<string> ids, bool? getFamily, bool? includeRouteBlockedStops, bool? flattenResponse)
        {
            return DisruptionAsync(ids, getFamily, includeRouteBlockedStops, flattenResponse, CancellationToken.None);
        }

        /// <summary>Gets all disruptions for the specified StopPointId, plus disruptions for any child Naptan records it may have.</summary>
        /// <param name="ids">A comma-seperated list of stop point ids. Max. approx. 20 ids.
        ///             You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param>
        /// <param name="getFamily">Specify true to return disruptions for entire family, or false to return disruptions for just this stop point. Defaults to false.</param>
        /// <param name="flattenResponse">Specify true to associate all disruptions with parent stop point. (Only applicable when getFamily is true).</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<DisruptedPoint>> DisruptionAsync(IEnumerable<string> ids, bool? getFamily, bool? includeRouteBlockedStops, bool? flattenResponse, CancellationToken cancellationToken)
        {
            if (ids == null)
                throw new ArgumentNullException("ids");

            return await GetAsync<ObservableCollection<DisruptedPoint>>(cancellationToken, "/StopPoint/{ids}/Disruption", ("ids", ids), ("getFamily", getFamily), ("includeRouteBlockedStops", includeRouteBlockedStops), ("flattenResponse", flattenResponse));
        }

        /// <summary>Returns the canonical direction, "inbound" or "outbound", for a given pair of stop point Ids in the direction from -&gt; to.</summary>
        /// <param name="id">Originating stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="toStopPointId">Destination stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="lineId">Optional line id filter e.g. victoria</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<string> DirectionAsync(string id, string toStopPointId, string lineId)
        {
            return DirectionAsync(id, toStopPointId, lineId, CancellationToken.None);
        }

        /// <summary>Returns the canonical direction, "inbound" or "outbound", for a given pair of stop point Ids in the direction from -&gt; to.</summary>
        /// <param name="id">Originating stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="toStopPointId">Destination stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="lineId">Optional line id filter e.g. victoria</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<string> DirectionAsync(string id, string toStopPointId, string lineId, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            if (toStopPointId == null)
                throw new ArgumentNullException("toStopPointId");

            return await GetAsync<string>(cancellationToken, "/StopPoint/{id}/DirectionTo/{toStopPointId}", ("id", id), ("toStopPointId", toStopPointId));
        }

        /// <summary>Gets a list of StopPoints within {radius} by the specified criteria</summary>
        /// <param name="stopTypes">a list of stopTypes that should be returned (a list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint)</param>
        /// <param name="radius">the radius of the bounding circle in metres (default : 200)</param>
        /// <param name="useStopPointHierarchy">Re-arrange the output into a parent/child hierarchy</param>
        /// <param name="modes">the list of modes to search (comma separated mode names e.g. tube,dlr)</param>
        /// <param name="categories">an optional list of comma separated property categories to return in the StopPoint's property bag. If null or empty, all categories of property are returned. Pass the keyword "none" to return no properties (a valid list of categories can be obtained from the /StopPoint/Meta/categories endpoint)</param>
        /// <param name="returnLines">true to return the lines that each stop point serves as a nested resource</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<StopPointsResponse> GetByGeoPointAsync(IEnumerable<string> stopTypes, int? radius, bool? useStopPointHierarchy, IEnumerable<string> modes, IEnumerable<string> categories, bool? returnLines, double locationlat, double locationlon)
        {
            return GetByGeoPointAsync(stopTypes, radius, useStopPointHierarchy, modes, categories, returnLines, locationlat, locationlon, CancellationToken.None);
        }

        /// <summary>Gets a list of StopPoints within {radius} by the specified criteria</summary>
        /// <param name="stopTypes">a list of stopTypes that should be returned (a list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint)</param>
        /// <param name="radius">the radius of the bounding circle in metres (default : 200)</param>
        /// <param name="useStopPointHierarchy">Re-arrange the output into a parent/child hierarchy</param>
        /// <param name="modes">the list of modes to search (comma separated mode names e.g. tube,dlr)</param>
        /// <param name="categories">an optional list of comma separated property categories to return in the StopPoint's property bag. If null or empty, all categories of property are returned. Pass the keyword "none" to return no properties (a valid list of categories can be obtained from the /StopPoint/Meta/categories endpoint)</param>
        /// <param name="returnLines">true to return the lines that each stop point serves as a nested resource</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<StopPointsResponse> GetByGeoPointAsync(IEnumerable<string> stopTypes, int? radius, bool? useStopPointHierarchy, IEnumerable<string> modes, IEnumerable<string> categories, bool? returnLines, double locationlat, double locationlon, CancellationToken cancellationToken)
        {
            if (stopTypes == null)
                throw new ArgumentNullException("stopTypes");

            return await GetAsync<StopPointsResponse>(cancellationToken, 
                "/StopPoint", 
                ("stopTypes", stopTypes), 
                ("radius", radius),
                ("useStopPointHierarchy", useStopPointHierarchy),
                ("modes", modes),
                ("categories", categories),
                ("returnLines", returnLines),
                ("locationLat", locationlat),
                ("locationLon", locationlon)
                );
        }

        /// <summary>Gets a list of StopPoints filtered by the modes available at that StopPoint.</summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param>
        /// <param name="page">The data set page to return. Page 1 equates to the first 1000 stop points, page 2 equates to 1001-2000 etc. Must be entered for bus mode as data set is too large.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<StopPointsResponse> GetByModeAsync(IEnumerable<string> modes, int? page)
        {
            return GetByModeAsync(modes, page, CancellationToken.None);
        }

        /// <summary>Gets a list of StopPoints filtered by the modes available at that StopPoint.</summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param>
        /// <param name="page">The data set page to return. Page 1 equates to the first 1000 stop points, page 2 equates to 1001-2000 etc. Must be entered for bus mode as data set is too large.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<StopPointsResponse> GetByModeAsync(IEnumerable<string> modes, int? page, CancellationToken cancellationToken)
        {
            if (modes == null)
                throw new ArgumentNullException("modes");

            return await GetAsync<StopPointsResponse>(cancellationToken, "/StopPoint/Mode/{modes}", ("modes", modes), ("page", page));
        }

        /// <summary>Search StopPoints by their common name, or their 5-digit Countdown Bus Stop Code.</summary>
        /// <param name="query">The query string, case-insensitive. Leading and trailing wildcards are applied automatically.</param>
        /// <param name="modes">An optional, parameter separated list of the modes to filter by</param>
        /// <param name="faresOnly">True to only return stations in that have Fares data available for single fares to another station.</param>
        /// <param name="maxResults">An optional result limit, defaulting to and with a maximum of 50. Since children of the stop point heirarchy are returned for matches,
        ///             it is possible that the flattened result set will contain more than 50 items.</param>
        /// <param name="lines">An optional, parameter separated list of the lines to filter by</param>
        /// <param name="includeHubs">If true, returns results including HUBs.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<SearchResponse> SearchAsync(string query, IEnumerable<string> modes, bool? faresOnly, int? maxResults, IEnumerable<string> lines, bool? includeHubs)
        {
            return SearchAsync(query, modes, faresOnly, maxResults, lines, includeHubs, CancellationToken.None);
        }

        /// <summary>Search StopPoints by their common name, or their 5-digit Countdown Bus Stop Code.</summary>
        /// <param name="query">The query string, case-insensitive. Leading and trailing wildcards are applied automatically.</param>
        /// <param name="modes">An optional, parameter separated list of the modes to filter by</param>
        /// <param name="faresOnly">True to only return stations in that have Fares data available for single fares to another station.</param>
        /// <param name="maxResults">An optional result limit, defaulting to and with a maximum of 50. Since children of the stop point heirarchy are returned for matches,
        ///             it is possible that the flattened result set will contain more than 50 items.</param>
        /// <param name="lines">An optional, parameter separated list of the lines to filter by</param>
        /// <param name="includeHubs">If true, returns results including HUBs.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<SearchResponse> SearchAsync(string query, IEnumerable<string> modes, bool? faresOnly, int? maxResults, IEnumerable<string> lines, bool? includeHubs, CancellationToken cancellationToken)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            return await GetAsync<SearchResponse>(cancellationToken, 
                "/StopPoint/Search/{query}", 
                ("query", query), 
                ("modes", modes), 
                ("faresOnly", faresOnly), 
                ("maxResults", maxResults), 
                ("lines", lines), 
                ("includeHubs", includeHubs)
                );
        }

        /// <summary>Gets a StopPoint for a given sms code.</summary>
        /// <param name="id">A 5-digit Countdown Bus Stop Code e.g. 73241, 50435, 56334.</param>
        /// <param name="output">If set to "web", a 302 redirect to relevant website bus stop page is returned. Valid values are : web. All other values are ignored.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<object> GetBySmsAsync(string id, string output)
        {
            return GetBySmsAsync(id, output, CancellationToken.None);
        }

        /// <summary>Gets a StopPoint for a given sms code.</summary>
        /// <param name="id">A 5-digit Countdown Bus Stop Code e.g. 73241, 50435, 56334.</param>
        /// <param name="output">If set to "web", a 302 redirect to relevant website bus stop page is returned. Valid values are : web. All other values are ignored.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<object> GetBySmsAsync(string id, string output, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<object>(cancellationToken, "/StopPoint/Sms/{id}", ("id", id), ("output", output));
        }

        /// <summary>Gets a list of taxi ranks corresponding to the given stop point id.</summary>
        /// <param name="stopPointId">stopPointId is required to get the taxi ranks.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public Task<ObservableCollection<Place>> GetTaxiRanksByIdsAsync(string stopPointId)
        {
            return GetTaxiRanksByIdsAsync(stopPointId, CancellationToken.None);
        }

        /// <summary>Gets a list of taxi ranks corresponding to the given stop point id.</summary>
        /// <param name="stopPointId">stopPointId is required to get the taxi ranks.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiStopPointException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Place>> GetTaxiRanksByIdsAsync(string stopPointId, CancellationToken cancellationToken)
        {
            if (stopPointId == null)
                throw new ArgumentNullException("stopPointId");

            return await GetAsync<ObservableCollection<Place>>(cancellationToken, "/StopPoint/{stopPointId}/TaxiRanks", ("stopPointId", stopPointId));
        }
    }
}
