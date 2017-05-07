namespace TflUnifiedApiClient
{
    /// <summary>Represents a point located at a latitude and longitude using the WGS84 co-ordinate system.</summary>

    public class Point
    {
        /// <summary>WGS84 latitude of the location.</summary>
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        /// <summary>WGS84 longitude of the location.</summary>
        [Newtonsoft.Json.JsonProperty("lon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lon { get; set; }

    }
}

