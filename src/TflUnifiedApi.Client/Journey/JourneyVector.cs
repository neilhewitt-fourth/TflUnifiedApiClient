namespace TflUnifiedApiClient
{
    public class JourneyVector
    {
        [Newtonsoft.Json.JsonProperty("from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string From { get; set; }

        [Newtonsoft.Json.JsonProperty("to", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string To { get; set; }

        [Newtonsoft.Json.JsonProperty("via", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Via { get; set; }

        [Newtonsoft.Json.JsonProperty("uri", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Uri { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static JourneyVector FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<JourneyVector>(data);
        }
    }
}

