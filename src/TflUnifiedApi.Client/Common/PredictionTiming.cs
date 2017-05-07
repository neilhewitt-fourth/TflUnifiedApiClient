using System;

namespace TflUnifiedApiClient
{
    public class PredictionTiming
    {
        [Newtonsoft.Json.JsonProperty("countdownServerAdjustment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountdownServerAdjustment { get; set; }

        [Newtonsoft.Json.JsonProperty("source", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Source { get; set; }

        [Newtonsoft.Json.JsonProperty("insert", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Insert { get; set; }

        [Newtonsoft.Json.JsonProperty("read", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Read { get; set; }

        [Newtonsoft.Json.JsonProperty("sent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Sent { get; set; }

        [Newtonsoft.Json.JsonProperty("received", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Received { get; set; }

    }
}

