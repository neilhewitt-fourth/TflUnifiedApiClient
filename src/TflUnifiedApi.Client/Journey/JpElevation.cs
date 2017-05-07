namespace TflUnifiedApiClient
{
    public class JpElevation
    {
        [Newtonsoft.Json.JsonProperty("distance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Distance { get; set; }

        [Newtonsoft.Json.JsonProperty("startLat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StartLat { get; set; }

        [Newtonsoft.Json.JsonProperty("startLon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StartLon { get; set; }

        [Newtonsoft.Json.JsonProperty("endLat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EndLat { get; set; }

        [Newtonsoft.Json.JsonProperty("endLon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EndLon { get; set; }

        [Newtonsoft.Json.JsonProperty("heightFromPreviousPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? HeightFromPreviousPoint { get; set; }

        [Newtonsoft.Json.JsonProperty("gradient", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gradient { get; set; }

    }
}

