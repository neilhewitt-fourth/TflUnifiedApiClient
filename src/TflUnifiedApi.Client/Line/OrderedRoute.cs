using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class OrderedRoute
    {
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("naptanIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> NaptanIds { get; set; }

        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static OrderedRoute FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<OrderedRoute>(data);
        }
    }
}

