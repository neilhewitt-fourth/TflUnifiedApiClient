namespace TflUnifiedApiClient
{
    public class ActiveServiceType
    {
        [Newtonsoft.Json.JsonProperty("mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode { get; set; }

        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ActiveServiceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ActiveServiceType>(data);
        }
    }
}

