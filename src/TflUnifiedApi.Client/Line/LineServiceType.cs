using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class LineServiceType
    {
        [Newtonsoft.Json.JsonProperty("lineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineName { get; set; }

        [Newtonsoft.Json.JsonProperty("lineSpecificServiceTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<LineSpecificServiceType> LineSpecificServiceTypes { get; set; }

    }
}

