using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class RouteSequence
    {
        [Newtonsoft.Json.JsonProperty("lineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineId { get; set; }

        [Newtonsoft.Json.JsonProperty("lineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineName { get; set; }

        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        [Newtonsoft.Json.JsonProperty("isOutboundOnly", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsOutboundOnly { get; set; }

        [Newtonsoft.Json.JsonProperty("mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode { get; set; }

        [Newtonsoft.Json.JsonProperty("lineStrings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> LineStrings { get; set; }

        [Newtonsoft.Json.JsonProperty("stations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<MatchedStop> Stations { get; set; }

        [Newtonsoft.Json.JsonProperty("stopPointSequences", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<StopPointSequence> StopPointSequences { get; set; }

        [Newtonsoft.Json.JsonProperty("orderedLineRoutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<OrderedRoute> OrderedLineRoutes { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RouteSequence FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteSequence>(data);
        }
    }
}

