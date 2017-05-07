namespace TflUnifiedApiClient
{
    public class TwentyFourHourClockTime
    {
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hour { get; set; }

        [Newtonsoft.Json.JsonProperty("minute", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Minute { get; set; }

    }
}

