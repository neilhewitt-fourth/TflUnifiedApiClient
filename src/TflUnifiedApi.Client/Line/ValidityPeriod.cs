using System;

namespace TflUnifiedApiClient
{
    /// <summary>Represents a period for which a planned works is valid.</summary>

    public class ValidityPeriod
    {
        /// <summary>Gets or sets the start date.</summary>
        [Newtonsoft.Json.JsonProperty("fromDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? FromDate { get; set; }

        /// <summary>Gets or sets the end date.</summary>
        [Newtonsoft.Json.JsonProperty("toDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ToDate { get; set; }

        /// <summary>If true is a realtime status rather than planned or info</summary>
        [Newtonsoft.Json.JsonProperty("isNow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsNow { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static ValidityPeriod FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ValidityPeriod>(data);
        }
    }
}

