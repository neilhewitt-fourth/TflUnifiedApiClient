using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class StationInterval
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("intervals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Interval> Intervals { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StationInterval FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StationInterval>(data);
        }
    }
}

