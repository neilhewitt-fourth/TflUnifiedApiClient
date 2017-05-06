using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class RouteSection
    {
        /// <summary>The Id of the route</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The Id of the Line</summary>
        [Newtonsoft.Json.JsonProperty("lineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineId { get; set; }

        /// <summary>The route code</summary>
        [Newtonsoft.Json.JsonProperty("routeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RouteCode { get; set; }

        /// <summary>Name such as "72"</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>eg: N or S or I or O</summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>eg: Path coordindates</summary>
        [Newtonsoft.Json.JsonProperty("lineString", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineString { get; set; }

        /// <summary>eg: Origination Name</summary>
        [Newtonsoft.Json.JsonProperty("originationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OriginationName { get; set; }

        /// <summary>eg: Destination Name</summary>
        [Newtonsoft.Json.JsonProperty("destinationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationName { get; set; }

        [Newtonsoft.Json.JsonProperty("routeSectionNaptanEntrySequence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<RouteSectionNaptanEntrySequence> RouteSectionNaptanEntrySequence { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RouteSection FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteSection>(data);
        }
    }
}

