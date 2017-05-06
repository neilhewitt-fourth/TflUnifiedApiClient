using System;

namespace TflUnifiedApiClient
{
    public class RoadDisruptionSchedule
    {
        [Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RoadDisruptionSchedule FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RoadDisruptionSchedule>(data);
        }
    }
}

