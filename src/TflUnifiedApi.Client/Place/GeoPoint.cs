namespace TflUnifiedApiClient
{
    public class GeoPoint
    {
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.Always)]
        public double Lat { get; set; }

        [Newtonsoft.Json.JsonProperty("lon", Required = Newtonsoft.Json.Required.Always)]
        public double Lon { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static GeoPoint FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GeoPoint>(data);
        }
    }
}

