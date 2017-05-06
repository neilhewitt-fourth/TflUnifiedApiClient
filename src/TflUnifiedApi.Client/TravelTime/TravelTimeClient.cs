using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class TravelTimeClient : ApiClientBase
    {
        /// <summary>Gets the TravelTime overlay.</summary>
        /// <param name="z">The zoom level.</param>
        /// <param name="pinLat">The latitude of the pin.</param>
        /// <param name="pinLon">The longitude of the pin.</param>
        /// <param name="mapCenterLat">The map center latitude.</param>
        /// <param name="mapCenterLon">The map center longitude.</param>
        /// <param name="scenarioTitle">The title of the scenario.</param>
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param>
        /// <param name="modeId">The id of the mode.</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="direction">The direction of travel.</param>
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiTravelTimeException">A server side error occurred.</exception>
        public Task<object> GetOverlayAsync(int z, double pinLat, double pinLon, double mapCenterLat, double mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int width, int height, OverlayDirection direction, int travelTimeInterval)
        {
            return GetOverlayAsync(z, pinLat, pinLon, mapCenterLat, mapCenterLon, scenarioTitle, timeOfDayId, modeId, width, height, direction, travelTimeInterval, CancellationToken.None);
        }

        /// <summary>Gets the TravelTime overlay.</summary>
        /// <param name="z">The zoom level.</param>
        /// <param name="pinLat">The latitude of the pin.</param>
        /// <param name="pinLon">The longitude of the pin.</param>
        /// <param name="mapCenterLat">The map center latitude.</param>
        /// <param name="mapCenterLon">The map center longitude.</param>
        /// <param name="scenarioTitle">The title of the scenario.</param>
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param>
        /// <param name="modeId">The id of the mode.</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="direction">The direction of travel.</param>
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiTravelTimeException">A server side error occurred.</exception>
        public async Task<object> GetOverlayAsync(int z, double pinLat, double pinLon, double mapCenterLat, double mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int width, int height, OverlayDirection direction, int travelTimeInterval, CancellationToken cancellationToken)
        {
            if (scenarioTitle == null)
                throw new ArgumentNullException("scenarioTitle");

            if (timeOfDayId == null)
                throw new ArgumentNullException("timeOfDayId");

            if (modeId == null)
                throw new ArgumentNullException("modeId");

            return await GetAsync<object>(cancellationToken, 
                "/TravelTimes/overlay/{z}/mapcenter/{mapCenterLat}/{mapCenterLon}/pinlocation/{pinLat}/{pinLon}/dimensions/{width}/{height}", 
                ("z", z),
                ("mapCenterLat", mapCenterLat),
                ("mapCenterLon", mapCenterLon),
                ("pinLat", pinLat),
                ("pinLon", pinLon),
                ("width", width),
                ("height", height),
                ("scenarioTitle", scenarioTitle),
                ("timeOfDayId", timeOfDayId),
                ("modeId", modeId),
                ("direction", direction),
                ("travelTimeInterval", travelTimeInterval)
                );
        }

        /// <summary>Gets the TravelTime overlay.</summary>
        /// <param name="z">The zoom level.</param>
        /// <param name="pinLat">The latitude of the pin.</param>
        /// <param name="pinLon">The longitude of the pin.</param>
        /// <param name="mapCenterLat">The map center latitude.</param>
        /// <param name="mapCenterLon">The map center longitude.</param>
        /// <param name="scenarioTitle">The title of the scenario.</param>
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param>
        /// <param name="modeId">The id of the mode.</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="direction">The direction of travel.</param>
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiTravelTimeException">A server side error occurred.</exception>
        public Task<object> GetCompareOverlayAsync(int z, double pinLat, double pinLon, double mapCenterLat, double mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int width, int height, OverlayDirection direction, int travelTimeInterval, string compareType, string compareValue)
        {
            return GetCompareOverlayAsync(z, pinLat, pinLon, mapCenterLat, mapCenterLon, scenarioTitle, timeOfDayId, modeId, width, height, direction, travelTimeInterval, compareType, compareValue, CancellationToken.None);
        }

        /// <summary>Gets the TravelTime overlay.</summary>
        /// <param name="z">The zoom level.</param>
        /// <param name="pinLat">The latitude of the pin.</param>
        /// <param name="pinLon">The longitude of the pin.</param>
        /// <param name="mapCenterLat">The map center latitude.</param>
        /// <param name="mapCenterLon">The map center longitude.</param>
        /// <param name="scenarioTitle">The title of the scenario.</param>
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param>
        /// <param name="modeId">The id of the mode.</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="direction">The direction of travel.</param>
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiTravelTimeException">A server side error occurred.</exception>
        public async Task<object> GetCompareOverlayAsync(int z, double pinLat, double pinLon, double mapCenterLat, double mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int width, int height, OverlayDirection direction, int travelTimeInterval, string compareType, string compareValue, CancellationToken cancellationToken)
        {
            if (scenarioTitle == null)
                throw new ArgumentNullException("scenarioTitle");

            if (timeOfDayId == null)
                throw new ArgumentNullException("timeOfDayId");

            if (modeId == null)
                throw new ArgumentNullException("modeId");

            return await GetAsync<object>(cancellationToken,
                "/TravelTimes/compareOverlay/{z}/mapcenter/{mapCenterLat}/{mapCenterLon}/pinlocation/{pinLat}/{pinLon}/dimensions/{width}/{height}",
                ("z", z),
                ("mapCenterLat", mapCenterLat),
                ("mapCenterLon", mapCenterLon),
                ("pinLat", pinLat),
                ("pinLon", pinLon),
                ("width", width),
                ("height", height),
                ("scenarioTitle", scenarioTitle),
                ("timeOfDayId", timeOfDayId),
                ("modeId", modeId),
                ("direction", direction),
                ("travelTimeInterval", travelTimeInterval)
                );
        }
    }
}
