namespace TflUnifiedApiClient
{
    public class Message
    {
        [Newtonsoft.Json.JsonProperty("bulletOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BulletOrder { get; set; }

        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Header { get; set; }

        [Newtonsoft.Json.JsonProperty("messageText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageText { get; set; }

        [Newtonsoft.Json.JsonProperty("linkText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LinkText { get; set; }

        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Message FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Message>(data);
        }
    }
}

