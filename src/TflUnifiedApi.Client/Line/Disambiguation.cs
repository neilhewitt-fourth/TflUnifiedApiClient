using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Disambiguation
    {
        [Newtonsoft.Json.JsonProperty("disambiguationOptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<DisambiguationOption> DisambiguationOptions { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Disambiguation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Disambiguation>(data);
        }
    }
}

