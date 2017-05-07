using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Schedule
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("knownJourneys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<KnownJourney> KnownJourneys { get; set; }

        [Newtonsoft.Json.JsonProperty("firstJourney", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KnownJourney FirstJourney { get; set; }

        [Newtonsoft.Json.JsonProperty("lastJourney", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public KnownJourney LastJourney { get; set; }

        [Newtonsoft.Json.JsonProperty("periods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Period> Periods { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Schedule FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Schedule>(data);
        }
    }
}

