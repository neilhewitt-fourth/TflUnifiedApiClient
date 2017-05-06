using System;

namespace TflUnifiedApiClient
{
    public class DateRangeNullable
    {
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DateRangeNullable FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DateRangeNullable>(data);
        }
    }
}

