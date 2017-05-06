using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Path
    {
        [Newtonsoft.Json.JsonProperty("lineString", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineString { get; set; }

        [Newtonsoft.Json.JsonProperty("stopPoints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Identifier> StopPoints { get; set; }

        [Newtonsoft.Json.JsonProperty("elevation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<JpElevation> Elevation { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Path FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Path>(data);
        }
    }
}

