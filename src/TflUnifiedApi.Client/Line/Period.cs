namespace TflUnifiedApiClient
{
    public class Period
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PeriodType? Type { get; set; }

        [Newtonsoft.Json.JsonProperty("fromTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TwentyFourHourClockTime FromTime { get; set; }

        [Newtonsoft.Json.JsonProperty("toTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TwentyFourHourClockTime ToTime { get; set; }

        [Newtonsoft.Json.JsonProperty("frequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ServiceFrequency Frequency { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Period FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Period>(data);
        }
    }
}

