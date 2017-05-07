using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class TimetableRoute
    {
        [Newtonsoft.Json.JsonProperty("stationIntervals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<StationInterval> StationIntervals { get; set; }

        [Newtonsoft.Json.JsonProperty("schedules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Schedule> Schedules { get; set; }

    }
}

