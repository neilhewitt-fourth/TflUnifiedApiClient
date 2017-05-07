using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class LineGroup
    {
        [Newtonsoft.Json.JsonProperty("naptanIdReference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NaptanIdReference { get; set; }

        [Newtonsoft.Json.JsonProperty("stationAtcoCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationAtcoCode { get; set; }

        [Newtonsoft.Json.JsonProperty("lineIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<string> LineIdentifier { get; set; }

    }
}

