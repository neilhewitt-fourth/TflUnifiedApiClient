namespace TflUnifiedApiClient
{
    public class DbGeography
    {
        [Newtonsoft.Json.JsonProperty("geography", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DbGeographyWellKnownValue Geography { get; set; }

    }
}

