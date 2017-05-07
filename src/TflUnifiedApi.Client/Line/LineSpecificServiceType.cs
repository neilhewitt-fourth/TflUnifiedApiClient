namespace TflUnifiedApiClient
{
    public class LineSpecificServiceType
    {
        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LineServiceTypeInfo ServiceType { get; set; }

        [Newtonsoft.Json.JsonProperty("stopServesServiceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? StopServesServiceType { get; set; }

    }
}

