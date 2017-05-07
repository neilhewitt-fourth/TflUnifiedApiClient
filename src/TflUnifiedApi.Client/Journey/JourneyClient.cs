using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TflUnifiedApiClient
{
    public class JourneyClient : ApiClientBase
    {
        /// <summary>Gets a list of all of the available journey planner modes</summary>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiJourneyException">A server side error occurred.</exception>
        public Task<IEnumerable<Mode>> MetaAsync()
        {
            return MetaAsync(CancellationToken.None);
        }

        /// <summary>Gets a list of all of the available journey planner modes</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiJourneyException">A server side error occurred.</exception>
        public async Task<IEnumerable<Mode>> MetaAsync(CancellationToken cancellationToken)
        {
            return await GetAsync<IEnumerable<Mode>>(cancellationToken, "/Journey/Meta/Modes");
        }

        /// <summary>Perform a Journey Planner search from the parameters specified in simple types</summary>
        /// <param name="from">Origin of the journey. Can be WGS84 coordinates expressed as "lat,long", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="to">Destination of the journey. Can be WGS84 coordinates expressed as "lat,long", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="via">Travel through point on the journey. Can be WGS84 coordinates expressed as "lat,long", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="nationalSearch">Does the journey cover stops outside London? eg. "nationalSearch=true"</param>
        /// <param name="date">The date must be in yyyyMMdd format</param>
        /// <param name="time">The time must be in HHmm format</param>
        /// <param name="timeIs">Does the time given relate to arrival or leaving time? Possible options: "departing" | "arriving"</param>
        /// <param name="journeyPreference">The journey preference eg possible options: "leastinterchange" | "leasttime" | "leastwalking"</param>
        /// <param name="mode">The mode must be a comma separated list of modes. eg possible options: "public-bus,overground,train,tube,coach,dlr,cablecar,tram,river,walking,cycle"</param>
        /// <param name="accessibilityPreference">The accessibility preference must be a comma separated list eg. "noSolidStairs,noEscalators,noElevators,stepFreeToVehicle,stepFreeToPlatform"</param>
        /// <param name="fromName">An optional name to associate with the origin of the journey in the results.</param>
        /// <param name="toName">An optional name to associate with the destination of the journey in the results.</param>
        /// <param name="viaName">An optional name to associate with the via point of the journey in the results.</param>
        /// <param name="maxTransferMinutes">The max walking time in minutes for transfer eg. "120"</param>
        /// <param name="maxWalkingMinutes">The max walking time in minutes for journeys eg. "120"</param>
        /// <param name="walkingSpeed">The walking speed. eg possible options: "slow" | "average" | "fast".</param>
        /// <param name="cyclePreference">The cycle preference. eg possible options: "allTheWay" | "leaveAtStation" | "takeOnTransport" | "cycleHire"</param>
        /// <param name="adjustment">Time adjustment command. eg possible options: "TripFirst" | "TripLast"</param>
        /// <param name="bikeProficiency">A comma separated list of cycling proficiency levels. eg possible options: "easy,moderate,fast"</param>
        /// <param name="alternativeCycle">Option to determine whether to return alternative cycling journey</param>
        /// <param name="alternativeWalking">Option to determine whether to return alternative walking journey</param>
        /// <param name="applyHtmlMarkup">Flag to determine whether certain text (e.g. walking instructions) should be output with HTML tags or not.</param>
        /// <param name="useMultiModalCall">A boolean to indicate whether or not to return 3 public transport journeys, a bus journey, a cycle hire journey, a personal cycle journey and a walking journey</param>
        /// <param name="walkingOptimization">A boolean to indicate whether to optimize journeys using walking</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiJourneyException">A server side error occurred.</exception>
        public Task<ItineraryResult> JourneyResultsAsync(string from, string to, string via, bool? nationalSearch, string date, string time, TimeIs? timeIs, JourneyPreference? journeyPreference, IEnumerable<string> mode, IEnumerable<AcessibilityPreference> accessibilityPreference, string fromName, string toName, string viaName, string maxTransferMinutes, string maxWalkingMinutes, WalkingSpeed? walkingSpeed, CyclePreference? cyclePreference, string adjustment, IEnumerable<BikeProficiency> bikeProficiency, bool? alternativeCycle, bool? alternativeWalking, bool? applyHtmlMarkup, bool? useMultiModalCall, bool? walkingOptimization)
        {
            return JourneyResultsAsync(from, to, via, nationalSearch, date, time, timeIs, journeyPreference, mode, accessibilityPreference, fromName, toName, viaName, maxTransferMinutes, maxWalkingMinutes, walkingSpeed, cyclePreference, adjustment, bikeProficiency, alternativeCycle, alternativeWalking, applyHtmlMarkup, useMultiModalCall, walkingOptimization, CancellationToken.None);
        }

        /// <summary>Perform a Journey Planner search from the parameters specified in simple types</summary>
        /// <param name="from">Origin of the journey. Can be WGS84 coordinates expressed as "lat,long", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="to">Destination of the journey. Can be WGS84 coordinates expressed as "lat,long", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="via">Travel through point on the journey. Can be WGS84 coordinates expressed as "lat,long", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="nationalSearch">Does the journey cover stops outside London? eg. "nationalSearch=true"</param>
        /// <param name="date">The date must be in yyyyMMdd format</param>
        /// <param name="time">The time must be in HHmm format</param>
        /// <param name="timeIs">Does the time given relate to arrival or leaving time? Possible options: "departing" | "arriving"</param>
        /// <param name="journeyPreference">The journey preference eg possible options: "leastinterchange" | "leasttime" | "leastwalking"</param>
        /// <param name="mode">The mode must be a comma separated list of modes. eg possible options: "public-bus,overground,train,tube,coach,dlr,cablecar,tram,river,walking,cycle"</param>
        /// <param name="accessibilityPreference">The accessibility preference must be a comma separated list eg. "noSolidStairs,noEscalators,noElevators,stepFreeToVehicle,stepFreeToPlatform"</param>
        /// <param name="fromName">An optional name to associate with the origin of the journey in the results.</param>
        /// <param name="toName">An optional name to associate with the destination of the journey in the results.</param>
        /// <param name="viaName">An optional name to associate with the via point of the journey in the results.</param>
        /// <param name="maxTransferMinutes">The max walking time in minutes for transfer eg. "120"</param>
        /// <param name="maxWalkingMinutes">The max walking time in minutes for journeys eg. "120"</param>
        /// <param name="walkingSpeed">The walking speed. eg possible options: "slow" | "average" | "fast".</param>
        /// <param name="cyclePreference">The cycle preference. eg possible options: "allTheWay" | "leaveAtStation" | "takeOnTransport" | "cycleHire"</param>
        /// <param name="adjustment">Time adjustment command. eg possible options: "TripFirst" | "TripLast"</param>
        /// <param name="bikeProficiency">A comma separated list of cycling proficiency levels. eg possible options: "easy,moderate,fast"</param>
        /// <param name="alternativeCycle">Option to determine whether to return alternative cycling journey</param>
        /// <param name="alternativeWalking">Option to determine whether to return alternative walking journey</param>
        /// <param name="applyHtmlMarkup">Flag to determine whether certain text (e.g. walking instructions) should be output with HTML tags or not.</param>
        /// <param name="useMultiModalCall">A boolean to indicate whether or not to return 3 public transport journeys, a bus journey, a cycle hire journey, a personal cycle journey and a walking journey</param>
        /// <param name="walkingOptimization">A boolean to indicate whether to optimize journeys using walking</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="TflUnifiedApiJourneyException">A server side error occurred.</exception>
        public async Task<ItineraryResult> JourneyResultsAsync(string from, string to, string via, bool? nationalSearch, string date, string time, TimeIs? timeIs, JourneyPreference? journeyPreference, IEnumerable<string> mode, 
            IEnumerable<AcessibilityPreference> accessibilityPreference, string fromName, string toName, string viaName, string maxTransferMinutes, string maxWalkingMinutes, WalkingSpeed? walkingSpeed, CyclePreference? cyclePreference, 
            string adjustment, IEnumerable<BikeProficiency> bikeProficiency, bool? alternativeCycle, bool? alternativeWalking, bool? applyHtmlMarkup, bool? useMultiModalCall, bool? walkingOptimization, CancellationToken cancellationToken)
        {
            if (from == null)
                throw new ArgumentNullException("from");

            if (to == null)
                throw new ArgumentNullException("to");

            return await GetAsync<ItineraryResult>(cancellationToken,
                "/Cabwise/search",
                ("from", from),
                ("to", to),
                ("via", via),
                ("nationalSearch", nationalSearch),
                ("date", date),
                ("time", time),
                ("timeIs", timeIs),
                ("journeyPreference", journeyPreference),
                ("mode", mode),
                ("accessibilityPreference", accessibilityPreference),
                ("fromName", fromName),
                ("toName", toName),
                ("viaName", viaName),
                ("maxTransferMinutes", maxTransferMinutes),
                ("maxWalkingMinutes", maxWalkingMinutes),
                ("walkingSpeed", walkingSpeed),
                ("cyclePreference", cyclePreference),
                ("adjustment", adjustment),
                ("bikeProficiency", bikeProficiency),
                ("alternativeCycle", alternativeCycle),
                ("alternativeWalking", alternativeWalking),
                ("applyHtmlMarkup", applyHtmlMarkup),
                ("useMultiModalCall", useMultiModalCall),
                ("walkingOptimization", walkingOptimization)
                );
        }

    }
}
