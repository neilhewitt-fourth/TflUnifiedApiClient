namespace TflUnifiedApiClient
{
    public class RouteSectionNaptanEntrySequence
    {
        [Newtonsoft.Json.JsonProperty("ordinal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Ordinal { get; set; }

        [Newtonsoft.Json.JsonProperty("stopPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StopPoint StopPoint { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RouteSectionNaptanEntrySequence FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteSectionNaptanEntrySequence>(data);
        }
    }
}

