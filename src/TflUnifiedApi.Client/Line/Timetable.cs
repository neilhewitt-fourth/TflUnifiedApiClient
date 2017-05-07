using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Timetable
    {
        [Newtonsoft.Json.JsonProperty("departureStopId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DepartureStopId { get; set; }

        [Newtonsoft.Json.JsonProperty("routes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<TimetableRoute> Routes { get; set; }

    }
}

