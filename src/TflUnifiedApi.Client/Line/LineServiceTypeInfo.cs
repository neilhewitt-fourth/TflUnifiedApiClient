namespace TflUnifiedApiClient
{
    public class LineServiceTypeInfo
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("uri", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Uri { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LineServiceTypeInfo FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LineServiceTypeInfo>(data);
        }
    }
}

