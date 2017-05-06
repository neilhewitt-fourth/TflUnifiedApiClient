namespace TflUnifiedApiClient
{
    public class Interval
    {
        [Newtonsoft.Json.JsonProperty("stopId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StopId { get; set; }

        [Newtonsoft.Json.JsonProperty("timeToArrival", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TimeToArrival { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Interval FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Interval>(data);
        }
    }
}

