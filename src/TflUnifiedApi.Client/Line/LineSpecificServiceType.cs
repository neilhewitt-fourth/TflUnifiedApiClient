namespace TflUnifiedApiClient
{
    public class LineSpecificServiceType
    {
        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LineServiceTypeInfo ServiceType { get; set; }

        [Newtonsoft.Json.JsonProperty("stopServesServiceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? StopServesServiceType { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LineSpecificServiceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LineSpecificServiceType>(data);
        }
    }
}

