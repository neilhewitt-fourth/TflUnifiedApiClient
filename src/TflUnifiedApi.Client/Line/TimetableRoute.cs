using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class TimetableRoute
    {
        [Newtonsoft.Json.JsonProperty("stationIntervals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<StationInterval> StationIntervals { get; set; }

        [Newtonsoft.Json.JsonProperty("schedules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Schedule> Schedules { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static TimetableRoute FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TimetableRoute>(data);
        }
    }
}

