using System;
using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Leg
    {
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        [Newtonsoft.Json.JsonProperty("speed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed { get; set; }

        /// <summary>Describes the action the user need to take for this section, E.g. "walk to the
        ///             district line"</summary>
        [Newtonsoft.Json.JsonProperty("instruction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Instruction Instruction { get; set; }

        [Newtonsoft.Json.JsonProperty("obstacles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Obstacle> Obstacles { get; set; }

        [Newtonsoft.Json.JsonProperty("departureTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? DepartureTime { get; set; }

        [Newtonsoft.Json.JsonProperty("arrivalTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ArrivalTime { get; set; }

        [Newtonsoft.Json.JsonProperty("departurePoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Point DeparturePoint { get; set; }

        [Newtonsoft.Json.JsonProperty("arrivalPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Point ArrivalPoint { get; set; }

        [Newtonsoft.Json.JsonProperty("path", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Path Path { get; set; }

        [Newtonsoft.Json.JsonProperty("routeOptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<RouteOption> RouteOptions { get; set; }

        [Newtonsoft.Json.JsonProperty("mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Identifier Mode { get; set; }

        [Newtonsoft.Json.JsonProperty("disruptions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Disruption> Disruptions { get; set; }

        [Newtonsoft.Json.JsonProperty("plannedWorks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<PlannedWork> PlannedWorks { get; set; }

        [Newtonsoft.Json.JsonProperty("distance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        [Newtonsoft.Json.JsonProperty("isDisrupted", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsDisrupted { get; set; }

        [Newtonsoft.Json.JsonProperty("hasFixedLocations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HasFixedLocations { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Leg FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Leg>(data);
        }
    }
}

