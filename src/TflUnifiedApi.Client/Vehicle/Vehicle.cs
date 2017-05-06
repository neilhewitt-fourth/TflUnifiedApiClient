namespace TflUnifiedApiClient
{
    public class Vehicle
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Vehicle FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Vehicle>(data);
        }
    }
}

