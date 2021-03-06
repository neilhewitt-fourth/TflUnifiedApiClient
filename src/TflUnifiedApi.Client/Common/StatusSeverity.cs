﻿namespace TflUnifiedApiClient
{
    public class StatusSeverity
    {
        [Newtonsoft.Json.JsonProperty("modeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeName { get; set; }

        [Newtonsoft.Json.JsonProperty("severityLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SeverityLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StatusSeverity FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StatusSeverity>(data);
        }
    }
}

