using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Crowding
    {
        /// <summary>Busiest times at a station (static information)</summary>
        [Newtonsoft.Json.JsonProperty("passengerFlows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<PassengerFlow> PassengerFlows { get; set; }

        /// <summary>Train Loading on a scale 1-6, 1 being "Very quiet" and 6 being "Exceptionally busy" (static information)</summary>
        [Newtonsoft.Json.JsonProperty("trainLoadings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<TrainLoading> TrainLoadings { get; set; }

    }
}

