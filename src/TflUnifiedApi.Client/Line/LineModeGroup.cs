using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class LineModeGroup
    {
        [Newtonsoft.Json.JsonProperty("modeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeName { get; set; }

        [Newtonsoft.Json.JsonProperty("lineIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<string> LineIdentifier { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LineModeGroup FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LineModeGroup>(data);
        }
    }
}

