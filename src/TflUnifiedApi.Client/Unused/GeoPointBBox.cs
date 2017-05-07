namespace TflUnifiedApiClient
{
    public class GeoPointBBox
    {
        [Newtonsoft.Json.JsonProperty("swLat", Required = Newtonsoft.Json.Required.Always)]
        public double SwLat { get; set; }

        [Newtonsoft.Json.JsonProperty("swLon", Required = Newtonsoft.Json.Required.Always)]
        public double SwLon { get; set; }

        [Newtonsoft.Json.JsonProperty("neLat", Required = Newtonsoft.Json.Required.Always)]
        public double NeLat { get; set; }

        [Newtonsoft.Json.JsonProperty("neLon", Required = Newtonsoft.Json.Required.Always)]
        public double NeLon { get; set; }

    }
}

