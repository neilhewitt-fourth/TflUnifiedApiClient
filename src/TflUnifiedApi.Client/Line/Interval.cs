namespace TflUnifiedApiClient
{
    public class Interval
    {
        [Newtonsoft.Json.JsonProperty("stopId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StopId { get; set; }

        [Newtonsoft.Json.JsonProperty("timeToArrival", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TimeToArrival { get; set; }

    }
}

