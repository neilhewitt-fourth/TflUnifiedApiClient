namespace TflUnifiedApiClient
{
    public class JourneyPlannerCycleHireDockingStationData
    {
        [Newtonsoft.Json.JsonProperty("originNumberOfBikes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OriginNumberOfBikes { get; set; }

        [Newtonsoft.Json.JsonProperty("destinationNumberOfBikes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DestinationNumberOfBikes { get; set; }

        [Newtonsoft.Json.JsonProperty("originNumberOfEmptySlots", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OriginNumberOfEmptySlots { get; set; }

        [Newtonsoft.Json.JsonProperty("destinationNumberOfEmptySlots", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DestinationNumberOfEmptySlots { get; set; }

        [Newtonsoft.Json.JsonProperty("originId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginId { get; set; }

        [Newtonsoft.Json.JsonProperty("destinationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationId { get; set; }

    }
}

