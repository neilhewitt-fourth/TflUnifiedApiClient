using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Ticket
    {
        [Newtonsoft.Json.JsonProperty("passengerType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PassengerType { get; set; }

        [Newtonsoft.Json.JsonProperty("ticketType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TicketType TicketType { get; set; }

        [Newtonsoft.Json.JsonProperty("ticketTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TicketTime TicketTime { get; set; }

        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cost { get; set; }

        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        [Newtonsoft.Json.JsonProperty("mode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode { get; set; }

        [Newtonsoft.Json.JsonProperty("displayOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DisplayOrder { get; set; }

        [Newtonsoft.Json.JsonProperty("messages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Message> Messages { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Ticket FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Ticket>(data);
        }
    }
}

