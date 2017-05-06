namespace TflUnifiedApiClient
{
    public class Mode
    {
        [Newtonsoft.Json.JsonProperty("isTflService", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsTflService { get; set; }

        [Newtonsoft.Json.JsonProperty("isFarePaying", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsFarePaying { get; set; }

        [Newtonsoft.Json.JsonProperty("isScheduledService", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsScheduledService { get; set; }

        [Newtonsoft.Json.JsonProperty("modeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeName { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Mode FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Mode>(data);
        }
    }
}

