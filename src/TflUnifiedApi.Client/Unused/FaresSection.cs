using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class FaresSection
    {
        [Newtonsoft.Json.JsonProperty("header", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Header { get; set; }

        [Newtonsoft.Json.JsonProperty("index", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Index { get; set; }

        [Newtonsoft.Json.JsonProperty("rows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<FareDetails> Rows { get; set; }

        [Newtonsoft.Json.JsonProperty("messages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Message> Messages { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static FaresSection FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FaresSection>(data);
        }
    }
}

