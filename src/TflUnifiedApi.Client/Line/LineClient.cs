﻿using System;
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
    public class LineClient : ApiClientBase
    {
        /// <summary>Gets a list of all of the valid modes to filter lines by</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Mode>> MetaModesAsync()
        {
            return MetaModesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of all of the valid modes to filter lines by</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Mode>> MetaModesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<Mode>>(cancellationToken, "/Line/Meta/Modes");
        }

        /// <summary>Gets a list of valid severity codes</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<StatusSeverity>> MetaSeverityAsync()
        {
            return MetaSeverityAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of valid severity codes</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<StatusSeverity>> MetaSeverityAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<StatusSeverity>>(cancellationToken, "/Line/Meta/Severity");
        }

        /// <summary>Gets a list of valid categories to filter disruptions</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<string>> MetaDisruptionCategoriesAsync()
        {
            return MetaDisruptionCategoriesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of valid categories to filter disruptions</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<string>> MetaDisruptionCategoriesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<string>>(cancellationToken, "/Line/Meta/DisruptionCategories");
        }

        /// <summary>Gets a list of valid ServiceTypes to filter on</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<string>> MetaServiceTypesAsync()
        {
            return MetaServiceTypesAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of valid ServiceTypes to filter on</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<string>> MetaServiceTypesAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<string>>(cancellationToken, "/Line/Meta/ServiceTypes");
        }

        /// <summary>Gets line specified by the line id.</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> GetAsync(IEnumerable<string> IDs)
        {
            return GetAsync(IDs, CancellationToken.None);
        }

        /// <summary>Gets line specified by the line id.</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> GetAsync(IEnumerable<string> IDs, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/{IDs}", ("IDs", IDs));
        }

        /// <summary>Gets line specified by provided modes.</summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> GetByModeAsync(IEnumerable<string> modes)
        {
            return GetByModeAsync(modes, CancellationToken.None);
        }

        /// <summary>Gets line specified by provided modes.</summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> GetByModeAsync(IEnumerable<string> modes, CancellationToken cancellationToken)
        {
            if (modes == null)
                throw new ArgumentNullException("modes");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/Mode/{modes}", ("modes", modes));
        }

        /// <summary>Get all valid routes for given line IDs, including the name and id of the originating and terminating stops for each route.</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> LineRoutesByIdsAsync(IEnumerable<string> IDs, IEnumerable<ServiceType> serviceTypes)
        {
            return LineRoutesByIdsAsync(IDs, serviceTypes, CancellationToken.None);
        }

        /// <summary>Get all valid routes for given line IDs, including the name and id of the originating and terminating stops for each route.</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> LineRoutesByIdsAsync(IEnumerable<string> IDs, IEnumerable<ServiceType> serviceTypes, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/{IDs}/Route", ("IDs", IDs));
        }

        /// <summary>Gets all lines and their valid routes for given modes, including the name and id of the originating and terminating stops for each route</summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> RouteByModeAsync(IEnumerable<string> modes, IEnumerable<ServiceType> serviceTypes)
        {
            return RouteByModeAsync(modes, serviceTypes, CancellationToken.None);
        }

        /// <summary>Gets all lines and their valid routes for given modes, including the name and id of the originating and terminating stops for each route</summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> RouteByModeAsync(IEnumerable<string> modes, IEnumerable<ServiceType> serviceTypes, CancellationToken cancellationToken)
        {
            if (modes == null)
                throw new ArgumentNullException("modes");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/Mode/{modes}/Route", ("modes", modes));
        }

        /// <summary>Gets all valid routes for given line id, including the sequence of stops on each route.</summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="excludeCrowding">That excludes crowding from line disruptions. Can be true or false.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<RouteSequence> RouteSequenceAsync(string id, Direction direction, IEnumerable<ServiceType> serviceTypes, bool? excludeCrowding)
        {
            return RouteSequenceAsync(id, direction, serviceTypes, excludeCrowding, CancellationToken.None);
        }

        /// <summary>Gets all valid routes for given line id, including the sequence of stops on each route.</summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="excludeCrowding">That excludes crowding from line disruptions. Can be true or false.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<RouteSequence> RouteSequenceAsync(string id, Direction direction, IEnumerable<ServiceType> serviceTypes, bool? excludeCrowding, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<RouteSequence>(cancellationToken, "/Line/{id}/Route/Sequence/{direction}", ("id", id), ("direction", direction));
        }

        /// <summary>Gets the line status for given line IDs during the provided dates e.g Minor Delays</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> StatusAsync(IEnumerable<string> IDs, bool? detail, DateTime? dateRangestartDate, DateTime? dateRangeendDate)
        {
            return StatusAsync(IDs, detail, dateRangestartDate, dateRangeendDate, CancellationToken.None);
        }

        /// <summary>Gets the line status for given line IDs during the provided dates e.g Minor Delays</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> StatusAsync(IEnumerable<string> IDs, bool? detail, DateTime? dateRangestartDate, DateTime? dateRangeendDate, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, 
                "/Line/{IDs}/Status",
                ("IDs", IDs),
                ("dateRange.startDate", dateRangestartDate),
                ("dateRange.endDate", dateRangeendDate),
                ("detail", detail)
                );
        }

        /// <summary>Gets the line status of for given line IDs e.g Minor Delays</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> StatusByIdsAsync(IEnumerable<string> IDs, bool? detail)
        {
            return StatusByIdsAsync(IDs, detail, CancellationToken.None);
        }

        /// <summary>Gets the line status of for given line IDs e.g Minor Delays</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> StatusByIdsAsync(IEnumerable<string> IDs, bool? detail, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/{IDs}/Status", ("IDs", IDs));
        }

        /// <summary>Search for lines or routes matching the query string</summary>
        /// <param name="query">Search term e.g victoria</param>
        /// <param name="modes">Optionally filter by the specified modes</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<RouteSearchResponse> SearchAsync(string query, IEnumerable<string> modes, IEnumerable<ServiceType> serviceTypes)
        {
            return SearchAsync(query, modes, serviceTypes, CancellationToken.None);
        }

        /// <summary>Search for lines or routes matching the query string</summary>
        /// <param name="query">Search term e.g victoria</param>
        /// <param name="modes">Optionally filter by the specified modes</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to 'Regular' if not specified</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<RouteSearchResponse> SearchAsync(string query, IEnumerable<string> modes, IEnumerable<ServiceType> serviceTypes, CancellationToken cancellationToken)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            return await GetAsync<RouteSearchResponse>(cancellationToken, "/Line/Search/{query}", ("query", query));
        }

        /// <summary>Gets the line status for all lines with a given severity
        ///             A list of valid severity codes can be obtained from a call to Line/Meta/Severity</summary>
        /// <param name="severity">The level of severity (eg: a number from 0 to 14)</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> StatusBySeverityAsync(int severity)
        {
            return StatusBySeverityAsync(severity, CancellationToken.None);
        }

        /// <summary>Gets the line status for all lines with a given severity
        ///             A list of valid severity codes can be obtained from a call to Line/Meta/Severity</summary>
        /// <param name="severity">The level of severity (eg: a number from 0 to 14)</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> StatusBySeverityAsync(int severity, CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/Status/{severity}", ("severity", severity));
        }

        /// <summary>Gets the line status of for all lines for the given modes</summary>
        /// <param name="modes">A comma-separated list of modes to filter by. e.g. tube,dlr</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Line>> StatusByModeAsync(IEnumerable<string> modes, bool? detail)
        {
            return StatusByModeAsync(modes, detail, CancellationToken.None);
        }

        /// <summary>Gets the line status of for all lines for the given modes</summary>
        /// <param name="modes">A comma-separated list of modes to filter by. e.g. tube,dlr</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Line>> StatusByModeAsync(IEnumerable<string> modes, bool? detail, CancellationToken cancellationToken)
        {
            if (modes == null)
                throw new ArgumentNullException("modes");

            return await GetAsync<IEnumerable<Line>>(cancellationToken, "/Line/Mode/{modes}/Status", ("modes", modes));
        }

        /// <summary>Gets a list of the stations that serve the given line id</summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<StopPoint>> StopPointsAsync(string id)
        {
            return StopPointsAsync(id, CancellationToken.None);
        }

        /// <summary>Gets a list of the stations that serve the given line id</summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<StopPoint>> StopPointsAsync(string id, CancellationToken cancellationToken)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<IEnumerable<StopPoint>>(cancellationToken, "/Line/{id}/StopPoints", ("id", id));
        }

        /// <summary>Gets the timetable for a specified station on the give line</summary>
        /// <param name="fromStopPointId">The originating station's stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<TimetableResponse> TimetableAsync(string fromStopPointId, string id)
        {
            return TimetableAsync(fromStopPointId, id, CancellationToken.None);
        }

        /// <summary>Gets the timetable for a specified station on the give line</summary>
        /// <param name="fromStopPointId">The originating station's stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<TimetableResponse> TimetableAsync(string fromStopPointId, string id, CancellationToken cancellationToken)
        {
            if (fromStopPointId == null)
                throw new ArgumentNullException("fromStopPointId");

            if (id == null)
                throw new ArgumentNullException("id");

            return await GetAsync<TimetableResponse>(cancellationToken, "/Line/{id}/Timetable/{fromStopPointId}", ("fromStopPointId", fromStopPointId), ("id", id));
        }

        /// <summary>Gets the timetable for a specified station on the give line with specified destination</summary>
        /// <param name="fromStopPointId">The originating station's stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="toStopPointId">The destination stations's Naptan code</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<TimetableResponse> TimetableToAsync(string fromStopPointId, string id, string toStopPointId)
        {
            return TimetableToAsync(fromStopPointId, id, toStopPointId, CancellationToken.None);
        }

        /// <summary>Gets the timetable for a specified station on the give line with specified destination</summary>
        /// <param name="fromStopPointId">The originating station's stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="toStopPointId">The destination stations's Naptan code</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<TimetableResponse> TimetableToAsync(string fromStopPointId, string id, string toStopPointId, CancellationToken cancellationToken)
        {
            if (fromStopPointId == null)
                throw new ArgumentNullException("fromStopPointId");

            if (id == null)
                throw new ArgumentNullException("id");

            if (toStopPointId == null)
                throw new ArgumentNullException("toStopPointId");

            return await GetAsync<TimetableResponse>(cancellationToken, "/Line/{id}/Timetable/{fromStopPointId}/to/{toStopPointId}", ("fromStopPointId", fromStopPointId), ("id", id), ("toStopPointId", toStopPointId));
        }

        /// <summary>Get disruptions for the given line IDs</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Disruption>> DisruptionAsync(IEnumerable<string> IDs)
        {
            return DisruptionAsync(IDs, CancellationToken.None);
        }

        /// <summary>Get disruptions for the given line IDs</summary>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Disruption>> DisruptionAsync(IEnumerable<string> IDs, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<Disruption>>(cancellationToken, "/Line/{IDs}/Disruption", ("IDs", IDs));
        }

        /// <summary>Get disruptions for all lines of the given modes.</summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Disruption>> DisruptionByModeAsync(IEnumerable<string> modes)
        {
            return DisruptionByModeAsync(modes, CancellationToken.None);
        }

        /// <summary>Get disruptions for all lines of the given modes.</summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Disruption>> DisruptionByModeAsync(IEnumerable<string> modes, CancellationToken cancellationToken)
        {
            if (modes == null)
                throw new ArgumentNullException("modes");

            return await GetAsync<IEnumerable<Disruption>>(cancellationToken, "/Line/Mode/{modes}/Disruption", ("modes", modes));
        }

        /// <summary>Get the list of arrival predictions for given line IDs based at the given stop</summary>
        /// <param name="stopPointId">Id of stop to get arrival predictions for (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Prediction>> ArrivalsAllAsync(string stopPointId, IEnumerable<string> IDs)
        {
            return ArrivalsAllAsync(stopPointId, IDs, CancellationToken.None);
        }

        /// <summary>Get the list of arrival predictions for given line IDs based at the given stop</summary>
        /// <param name="stopPointId">Id of stop to get arrival predictions for (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Prediction>> ArrivalsAllAsync(string stopPointId, IEnumerable<string> IDs, CancellationToken cancellationToken)
        {
            if (IDs == null)
                throw new ArgumentNullException("IDs");

            if (stopPointId == null)
                throw new ArgumentNullException("stopPointId");

            return await GetAsync<IEnumerable<Prediction>>(cancellationToken, "/Line/{IDs}/Arrivals", ("IDs", IDs));
        }

        /// <summary>Get the list of arrival predictions for given line IDs based at the given stop going in the procided direction</summary>
        /// <param name="stopPointId">Id of stop to get arrival predictions for (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public Task<IEnumerable<Prediction>> ArrivalsAsync(string stopPointId, IEnumerable<string> IDs, Direction direction)
        {
            return ArrivalsAsync(stopPointId, IDs, direction, CancellationToken.None);
        }

        /// <summary>Get the list of arrival predictions for given line IDs based at the given stop going in the procided direction</summary>
        /// <param name="stopPointId">Id of stop to get arrival predictions for (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="IDs">A comma-separated list of line IDs e.g. victoria,circle,N133. Max. approx. 20 IDs.</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiLineException">A server side error occurred.</exception>
        public async Task<IEnumerable<Prediction>> ArrivalsAsync(string stopPointId, IEnumerable<string> IDs, Direction direction, CancellationToken cancellationToken)
        {
            if (stopPointId == null)
                throw new ArgumentNullException("stopPointId");

            if (IDs == null)
                throw new ArgumentNullException("IDs");

            return await GetAsync<IEnumerable<Prediction>>(cancellationToken, "/Line/{IDs}/Arrivals/{stopPointId}", ("IDs", IDs), ("stopPointId", stopPointId));
        }
    }
}