namespace TflUnifiedApiClient
{
    public class AccidentStatsOrderedSummary
    {
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Year { get; set; }

        [Newtonsoft.Json.JsonProperty("borough", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Borough { get; set; }

        [Newtonsoft.Json.JsonProperty("accidents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Accidents { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AccidentStatsOrderedSummary FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AccidentStatsOrderedSummary>(data);
        }
    }
}

