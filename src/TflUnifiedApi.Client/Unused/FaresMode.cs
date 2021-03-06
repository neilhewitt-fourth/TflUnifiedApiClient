﻿namespace TflUnifiedApiClient
{
    public class FaresMode
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static FaresMode FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FaresMode>(data);
        }
    }
}

