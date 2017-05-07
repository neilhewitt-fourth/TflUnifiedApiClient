using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class RouteSearchResponse
    {
        [Newtonsoft.Json.JsonProperty("input", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Input { get; set; }

        [Newtonsoft.Json.JsonProperty("searchMatches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<RouteSearchMatch> SearchMatches { get; set; }

    }
}

