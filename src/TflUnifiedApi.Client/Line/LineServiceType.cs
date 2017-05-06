using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class LineServiceType
    {
        [Newtonsoft.Json.JsonProperty("lineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineName { get; set; }

        [Newtonsoft.Json.JsonProperty("lineSpecificServiceTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<LineSpecificServiceType> LineSpecificServiceTypes { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LineServiceType FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LineServiceType>(data);
        }
    }
}

