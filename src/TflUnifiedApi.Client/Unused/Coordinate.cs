namespace TflUnifiedApiClient
{
    public class Coordinate
    {
        [Newtonsoft.Json.JsonProperty("longitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Longitude { get; set; }

        [Newtonsoft.Json.JsonProperty("latitude", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [Newtonsoft.Json.JsonProperty("easting", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Easting { get; set; }

        [Newtonsoft.Json.JsonProperty("northing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Northing { get; set; }

        [Newtonsoft.Json.JsonProperty("xCoord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? XCoord { get; set; }

        [Newtonsoft.Json.JsonProperty("yCoord", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? YCoord { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Coordinate FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Coordinate>(data);
        }
    }
}

