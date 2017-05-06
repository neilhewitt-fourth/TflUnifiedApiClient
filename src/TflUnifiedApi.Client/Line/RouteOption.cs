using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class RouteOption
    {
        /// <summary>The Id of the route</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>Name such as "72"</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("directions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> Directions { get; set; }

        /// <summary>The line identifier (e.g. District Line), from where you can obtain line status information e.g. the rainbow board status "good service".</summary>
        [Newtonsoft.Json.JsonProperty("lineIdentifier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Identifier LineIdentifier { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RouteOption FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RouteOption>(data);
        }
    }
}

