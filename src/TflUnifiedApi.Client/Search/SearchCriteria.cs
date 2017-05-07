using System;

namespace TflUnifiedApiClient
{
    public class SearchCriteria
    {
        [Newtonsoft.Json.JsonProperty("dateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? DateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("dateTimeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SearchCriteriaDateTimeType? DateTimeType { get; set; }

        [Newtonsoft.Json.JsonProperty("timeAdjustments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TimeAdjustments TimeAdjustments { get; set; }

    }
}

