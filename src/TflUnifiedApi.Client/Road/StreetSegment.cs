namespace TflUnifiedApiClient
{
    public class StreetSegment
    {
        /// <summary>A 16 digit unique integer identifying a OS ITN (Ordnance Survey Integrated Transport Network) road link.</summary>
        [Newtonsoft.Json.JsonProperty("toid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Toid { get; set; }

        /// <summary>geoJSON formatted LineString containing two latitude/longitude (WGS84) pairs that identify the start and end points of the street segment.</summary>
        [Newtonsoft.Json.JsonProperty("lineString", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineString { get; set; }

        /// <summary>The ID from the source system of the disruption that this street belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("sourceSystemId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SourceSystemId { get; set; }

        /// <summary>The key of the source system of the disruption that this street belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("sourceSystemKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSystemKey { get; set; }

    }
}

