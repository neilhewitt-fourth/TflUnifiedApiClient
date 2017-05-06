using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class TimetableResponse
    {
        [Newtonsoft.Json.JsonProperty("lineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineId { get; set; }

        [Newtonsoft.Json.JsonProperty("lineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineName { get; set; }

        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        [Newtonsoft.Json.JsonProperty("pdfUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PdfUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("stations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<MatchedStop> Stations { get; set; }

        [Newtonsoft.Json.JsonProperty("stops", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<MatchedStop> Stops { get; set; }

        [Newtonsoft.Json.JsonProperty("timetable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Timetable Timetable { get; set; }

        [Newtonsoft.Json.JsonProperty("disambiguation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Disambiguation Disambiguation { get; set; }

        [Newtonsoft.Json.JsonProperty("statusErrorMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusErrorMessage { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static TimetableResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<TimetableResponse>(data);
        }
    }
}

