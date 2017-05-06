using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class Recommendation
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("rule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rule { get; set; }

        [Newtonsoft.Json.JsonProperty("rank", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        [Newtonsoft.Json.JsonProperty("fareType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FareType { get; set; }

        [Newtonsoft.Json.JsonProperty("product", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Product { get; set; }

        [Newtonsoft.Json.JsonProperty("ticketType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TicketType { get; set; }

        [Newtonsoft.Json.JsonProperty("ticketTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TicketTime { get; set; }

        [Newtonsoft.Json.JsonProperty("productType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductType { get; set; }

        [Newtonsoft.Json.JsonProperty("discountCard", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DiscountCard { get; set; }

        [Newtonsoft.Json.JsonProperty("zones", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zones { get; set; }

        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cost { get; set; }

        [Newtonsoft.Json.JsonProperty("priceDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PriceDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("priceComparison", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PriceComparison { get; set; }

        [Newtonsoft.Json.JsonProperty("recommendedTopUp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecommendedTopUp { get; set; }

        [Newtonsoft.Json.JsonProperty("notes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Message> Notes { get; set; }

        [Newtonsoft.Json.JsonProperty("keyFeatures", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Message> KeyFeatures { get; set; }

        [Newtonsoft.Json.JsonProperty("gettingYourTicket", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Message> GettingYourTicket { get; set; }

        [Newtonsoft.Json.JsonProperty("singleFare", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SingleFare { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Recommendation FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Recommendation>(data);
        }
    }
}

