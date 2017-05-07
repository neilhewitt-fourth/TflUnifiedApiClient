namespace TflUnifiedApiClient
{
    public class GeoPoint
    {
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.Always)]
        public double Lat { get; set; }

        [Newtonsoft.Json.JsonProperty("lon", Required = Newtonsoft.Json.Required.Always)]
        public double Lon { get; set; }

    }
}

