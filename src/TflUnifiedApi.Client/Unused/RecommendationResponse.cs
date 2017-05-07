using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class RecommendationResponse
    {
        [Newtonsoft.Json.JsonProperty("recommendations", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<Recommendation> Recommendations { get; set; }

    }
}

