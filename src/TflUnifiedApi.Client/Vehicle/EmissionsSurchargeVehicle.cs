namespace TflUnifiedApiClient
{
    public class EmissionsSurchargeVehicle
    {
        [Newtonsoft.Json.JsonProperty("vrm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Vrm { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("make", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Make { get; set; }

        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Model { get; set; }

        [Newtonsoft.Json.JsonProperty("colour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Colour { get; set; }

        [Newtonsoft.Json.JsonProperty("compliance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmissionsSurchargeVehicleCompliance? Compliance { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static EmissionsSurchargeVehicle FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EmissionsSurchargeVehicle>(data);
        }
    }
}

