﻿namespace TflUnifiedApiClient
{
    public class TimeAdjustments
    {
        [Newtonsoft.Json.JsonProperty("earliest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TimeAdjustment Earliest { get; set; }

        [Newtonsoft.Json.JsonProperty("earlier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TimeAdjustment Earlier { get; set; }

        [Newtonsoft.Json.JsonProperty("later", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TimeAdjustment Later { get; set; }

        [Newtonsoft.Json.JsonProperty("latest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TimeAdjustment Latest { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static TimeAdjustments FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TimeAdjustments>(data);
        }
    }
}

