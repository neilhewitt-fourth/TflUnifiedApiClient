namespace TflUnifiedApiClient
{
    public class MatchedRouteSections
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static MatchedRouteSections FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MatchedRouteSections>(data);
        }
    }
}

