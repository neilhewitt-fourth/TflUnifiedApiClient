using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Instruction
    {
        [Newtonsoft.Json.JsonProperty("summary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [Newtonsoft.Json.JsonProperty("detailed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Detailed { get; set; }

        [Newtonsoft.Json.JsonProperty("steps", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<InstructionStep> Steps { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Instruction FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Instruction>(data);
        }
    }
}

