using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class RouteSearchResponse
    {
        [Newtonsoft.Json.JsonProperty("input", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Input { get; set; }

        [Newtonsoft.Json.JsonProperty("searchMatches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<RouteSearchMatch> SearchMatches { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RouteSearchResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteSearchResponse>(data);
        }
    }
}

