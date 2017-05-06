using System;
using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Line
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty("modeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeName { get; set; }

        [Newtonsoft.Json.JsonProperty("disruptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> Disruptions { get; set; }

        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [Newtonsoft.Json.JsonProperty("modified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        [Newtonsoft.Json.JsonProperty("lineStatuses", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<LineStatus> LineStatuses { get; set; }

        [Newtonsoft.Json.JsonProperty("routeSections", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<MatchedRoute> RouteSections { get; set; }

        [Newtonsoft.Json.JsonProperty("serviceTypes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<LineServiceTypeInfo> ServiceTypes { get; set; }

        [Newtonsoft.Json.JsonProperty("crowding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Crowding Crowding { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Line FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Line>(data);
        }
    }
}

