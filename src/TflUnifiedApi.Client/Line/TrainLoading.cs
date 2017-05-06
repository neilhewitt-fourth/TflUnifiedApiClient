namespace TflUnifiedApiClient
{
    public class TrainLoading
    {
        /// <summary>The Line Name e.g. "Victoria"</summary>
        [Newtonsoft.Json.JsonProperty("line", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Line { get; set; }

        /// <summary>Direction of the Line e.g. NB, SB, WB etc.</summary>
        [Newtonsoft.Json.JsonProperty("lineDirection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineDirection { get; set; }

        /// <summary>Direction displayed on the platform e.g. NB, SB, WB etc.</summary>
        [Newtonsoft.Json.JsonProperty("platformDirection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlatformDirection { get; set; }

        /// <summary>Direction in regards to Journey Planner i.e. inbound or outbound</summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>Naptan of the adjacent station</summary>
        [Newtonsoft.Json.JsonProperty("naptanTo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NaptanTo { get; set; }

        /// <summary>Time in 24hr format with 15 minute intervals e.g. 0500-0515, 0515-0530 etc.</summary>
        [Newtonsoft.Json.JsonProperty("timeSlice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeSlice { get; set; }

        /// <summary>Scale between 1-6, 
        ///              1 = Very quiet, 2 = Quiet, 3 = Fairly busy, 4 = Busy, 5 = Very busy, 6 = Exceptionally busy</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static TrainLoading FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TrainLoading>(data);
        }
    }
}

