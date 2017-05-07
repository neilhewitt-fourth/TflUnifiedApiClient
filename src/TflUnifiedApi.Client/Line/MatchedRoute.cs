namespace TflUnifiedApiClient
{
    public class MatchedRoute
    {
        /// <summary>The route code</summary>
        [Newtonsoft.Json.JsonProperty("routeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RouteCode { get; set; }

        /// <summary>Name such as "72"</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>eg: N or S or I or O</summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>eg: Origination Name</summary>
        [Newtonsoft.Json.JsonProperty("originationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginationName { get; set; }

        /// <summary>eg: Destination Name</summary>
        [Newtonsoft.Json.JsonProperty("destinationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationName { get; set; }

        /// <summary>eg: Origination</summary>
        [Newtonsoft.Json.JsonProperty("originator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Originator { get; set; }

        /// <summary>eg: Destination</summary>
        [Newtonsoft.Json.JsonProperty("destination", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>eg: Regular, Night</summary>
        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

    }
}

