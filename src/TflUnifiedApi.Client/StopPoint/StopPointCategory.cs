using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class StopPointCategory
    {
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        [Newtonsoft.Json.JsonProperty("availableKeys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> AvailableKeys { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopPointCategory FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopPointCategory>(data);
        }
    }
}

