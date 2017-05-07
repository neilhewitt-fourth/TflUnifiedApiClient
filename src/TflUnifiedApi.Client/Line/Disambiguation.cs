using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Disambiguation
    {
        [Newtonsoft.Json.JsonProperty("disambiguationOptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<DisambiguationOption> DisambiguationOptions { get; set; }

    }
}

