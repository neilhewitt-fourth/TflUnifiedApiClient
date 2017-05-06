using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class StopPointSequence
    {
        [Newtonsoft.Json.JsonProperty("lineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineId { get; set; }

        [Newtonsoft.Json.JsonProperty("lineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineName { get; set; }

        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>The id of this branch.</summary>
        [Newtonsoft.Json.JsonProperty("branchId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? BranchId { get; set; }

        /// <summary>The ids of the next branch(es) in the sequence. Note that the next and previous branch id can be
        ///             identical in the case of a looped route e.g. the Circle line.</summary>
        [Newtonsoft.Json.JsonProperty("nextBranchIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<int> NextBranchIds { get; set; }

        /// <summary>The ids of the previous branch(es) in the sequence. Note that the next and previous branch id can be
        ///             identical in the case of a looped route e.g. the Circle line.</summary>
        [Newtonsoft.Json.JsonProperty("prevBranchIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<int> PrevBranchIds { get; set; }

        [Newtonsoft.Json.JsonProperty("stopPoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<MatchedStop> StopPoint { get; set; }

        [Newtonsoft.Json.JsonProperty("serviceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public StopPointSequenceServiceType? ServiceType { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopPointSequence FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopPointSequence>(data);
        }
    }
}

