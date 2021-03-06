﻿namespace TflUnifiedApiClient
{
    public class PathAttribute
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static PathAttribute FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PathAttribute>(data);
        }
    }
}

