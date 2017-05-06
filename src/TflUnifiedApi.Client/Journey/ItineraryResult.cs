using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    /// <summary>A DTO representing a list of possible journeys.</summary>

    public class ItineraryResult
    {
        [Newtonsoft.Json.JsonProperty("journeys", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Journey> Journeys { get; set; }

        [Newtonsoft.Json.JsonProperty("lines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Line> Lines { get; set; }

        [Newtonsoft.Json.JsonProperty("cycleHireDockingStationData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public JourneyPlannerCycleHireDockingStationData CycleHireDockingStationData { get; set; }

        [Newtonsoft.Json.JsonProperty("stopMessages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<string> StopMessages { get; set; }

        [Newtonsoft.Json.JsonProperty("recommendedMaxAgeMinutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RecommendedMaxAgeMinutes { get; set; }

        [Newtonsoft.Json.JsonProperty("searchCriteria", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SearchCriteria SearchCriteria { get; set; }

        [Newtonsoft.Json.JsonProperty("journeyVector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public JourneyVector JourneyVector { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ItineraryResult FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ItineraryResult>(data);
        }
    }
}

