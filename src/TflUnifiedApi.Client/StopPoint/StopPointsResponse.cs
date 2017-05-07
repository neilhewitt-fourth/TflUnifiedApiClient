using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    /// <summary>A paged response containing StopPoints</summary>

    public class StopPointsResponse
    {
        /// <summary>The centre latitude/longitude of this list of StopPoints</summary>
        [Newtonsoft.Json.JsonProperty("centrePoint", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<double> CentrePoint { get; set; }

        /// <summary>Collection of stop points</summary>
        [Newtonsoft.Json.JsonProperty("stopPoints", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<StopPoint> StopPoints { get; set; }

        /// <summary>The maximum size of the page in this response i.e. the maximum number of StopPoints</summary>
        [Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>The total number of StopPoints available across all pages</summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>The index of this page</summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static StopPointsResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StopPointsResponse>(data);
        }
    }
}

