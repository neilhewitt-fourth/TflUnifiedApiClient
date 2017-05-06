using System;
using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{


    public class ApiVersionInfo
    {
        [Newtonsoft.Json.JsonProperty("label", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Label { get; set; }

        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Timestamp { get; set; }

        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }

        [Newtonsoft.Json.JsonProperty("assemblies", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> Assemblies { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ApiVersionInfo FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ApiVersionInfo>(data);
        }
    }    
}

