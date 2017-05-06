namespace TflUnifiedApiClient
{
    public class Redirect
    {
        [Newtonsoft.Json.JsonProperty("shortUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("longUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LongUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Redirect FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Redirect>(data);
        }
    }
}

