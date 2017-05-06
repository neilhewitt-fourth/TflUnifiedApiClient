namespace TflUnifiedApiClient
{
    public class Casualty
    {
        [Newtonsoft.Json.JsonProperty("age", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [Newtonsoft.Json.JsonProperty("class", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Class { get; set; }

        [Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Severity { get; set; }

        [Newtonsoft.Json.JsonProperty("mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode { get; set; }

        [Newtonsoft.Json.JsonProperty("ageBand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgeBand { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Casualty FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Casualty>(data);
        }
    }
}

