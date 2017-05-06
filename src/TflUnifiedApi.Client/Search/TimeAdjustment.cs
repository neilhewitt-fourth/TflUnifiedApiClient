namespace TflUnifiedApiClient
{
    public class TimeAdjustment
    {
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Date { get; set; }

        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Time { get; set; }

        [Newtonsoft.Json.JsonProperty("timeIs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeIs { get; set; }

        [Newtonsoft.Json.JsonProperty("uri", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Uri { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static TimeAdjustment FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TimeAdjustment>(data);
        }
    }
}

