using System;
using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class AccidentDetail
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        [Newtonsoft.Json.JsonProperty("lon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lon { get; set; }

        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        [Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Severity { get; set; }

        [Newtonsoft.Json.JsonProperty("borough", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Borough { get; set; }

        [Newtonsoft.Json.JsonProperty("casualties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Casualty> Casualties { get; set; }

        [Newtonsoft.Json.JsonProperty("vehicles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Vehicle> Vehicles { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static AccidentDetail FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AccidentDetail>(data);
        }
    }
}

