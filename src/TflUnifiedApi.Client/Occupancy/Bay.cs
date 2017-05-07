namespace TflUnifiedApiClient
{
    public class Bay
    {
        [Newtonsoft.Json.JsonProperty("bayType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BayType { get; set; }

        [Newtonsoft.Json.JsonProperty("bayCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BayCount { get; set; }

        [Newtonsoft.Json.JsonProperty("free", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Free { get; set; }

        [Newtonsoft.Json.JsonProperty("occupied", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Occupied { get; set; }

    }
}

