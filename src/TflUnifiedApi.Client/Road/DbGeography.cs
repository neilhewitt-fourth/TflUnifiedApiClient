namespace TflUnifiedApiClient
{
    public class DbGeography
    {
        [Newtonsoft.Json.JsonProperty("geography", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DbGeographyWellKnownValue Geography { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DbGeography FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DbGeography>(data);
        }
    }
}

