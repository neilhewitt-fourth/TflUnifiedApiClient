namespace TflUnifiedApiClient
{
    public class PassengerFlow
    {
        /// <summary>Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.</summary>
        [Newtonsoft.Json.JsonProperty("timeSlice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeSlice { get; set; }

        /// <summary>Count of passenger flow towards a platform</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PassengerFlow FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PassengerFlow>(data);
        }
    }
}

