using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class PlacePolygon
    {
        [Newtonsoft.Json.JsonProperty("geoPoints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<GeoPoint> GeoPoints { get; set; }

        [Newtonsoft.Json.JsonProperty("commonName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommonName { get; set; }

    }
}

