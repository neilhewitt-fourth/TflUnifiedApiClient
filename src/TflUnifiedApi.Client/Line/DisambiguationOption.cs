namespace TflUnifiedApiClient
{
    public class DisambiguationOption
    {
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("uri", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Uri { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DisambiguationOption FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DisambiguationOption>(data);
        }
    }
}

