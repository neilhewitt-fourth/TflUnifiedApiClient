using System;
using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class LineStatus
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("lineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineId { get; set; }

        [Newtonsoft.Json.JsonProperty("statusSeverity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? StatusSeverity { get; set; }

        [Newtonsoft.Json.JsonProperty("statusSeverityDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StatusSeverityDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        [Newtonsoft.Json.JsonProperty("modified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        [Newtonsoft.Json.JsonProperty("validityPeriods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<ValidityPeriod> ValidityPeriods { get; set; }

        [Newtonsoft.Json.JsonProperty("disruption", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Disruption Disruption { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static LineStatus FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<LineStatus>(data);
        }
    }
}

