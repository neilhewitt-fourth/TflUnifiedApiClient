using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Crowding
    {
        /// <summary>Busiest times at a station (static information)</summary>
        [Newtonsoft.Json.JsonProperty("passengerFlows", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<PassengerFlow> PassengerFlows { get; set; }

        /// <summary>Train Loading on a scale 1-6, 1 being "Very quiet" and 6 being "Exceptionally busy" (static information)</summary>
        [Newtonsoft.Json.JsonProperty("trainLoadings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<TrainLoading> TrainLoadings { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Crowding FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Crowding>(data);
        }
    }
}

