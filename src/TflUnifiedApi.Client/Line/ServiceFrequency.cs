namespace TflUnifiedApiClient
{
    public class ServiceFrequency
    {
        [Newtonsoft.Json.JsonProperty("lowestFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LowestFrequency { get; set; }

        [Newtonsoft.Json.JsonProperty("highestFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HighestFrequency { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ServiceFrequency FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ServiceFrequency>(data);
        }
    }
}

