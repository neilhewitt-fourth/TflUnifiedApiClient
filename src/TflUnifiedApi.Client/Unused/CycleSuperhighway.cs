using System;

namespace TflUnifiedApiClient
{
    public class CycleSuperhighway
    {
        /// <summary>The Id</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The long label to show on maps when zoomed in</summary>
        [Newtonsoft.Json.JsonProperty("label", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>The short label to show on maps</summary>
        [Newtonsoft.Json.JsonProperty("labelShort", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LabelShort { get; set; }

        /// <summary>A LineString or MultiLineString that forms the route of the highway</summary>
        [Newtonsoft.Json.JsonProperty("geography", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DbGeography Geography { get; set; }

        /// <summary>True if the route is split into segments</summary>
        [Newtonsoft.Json.JsonProperty("segmented", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Segmented { get; set; }

        /// <summary>When the data was last updated</summary>
        [Newtonsoft.Json.JsonProperty("modified", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Modified { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static CycleSuperhighway FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CycleSuperhighway>(data);
        }
    }
}

