using System;
using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    /// <summary>Represents a disruption to a route within the transport network.</summary>

    public class Disruption
    {
        /// <summary>Gets or sets the category of this dispruption.</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DisruptionCategory? Category { get; set; }

        /// <summary>Gets or sets the disruption type of this dispruption.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>Gets or sets the description of the category.</summary>
        [Newtonsoft.Json.JsonProperty("categoryDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryDescription { get; set; }

        /// <summary>Gets or sets the description of this disruption.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>Gets or sets the additionaInfo of this disruption.</summary>
        [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }

        /// <summary>Gets or sets the date/time when this disruption was created.</summary>
        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Created { get; set; }

        /// <summary>Gets or sets the date/time when this disruption was last updated.</summary>
        [Newtonsoft.Json.JsonProperty("lastUpdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? LastUpdate { get; set; }

        /// <summary>Gets or sets the routes affected by this disruption</summary>
        [Newtonsoft.Json.JsonProperty("affectedRoutes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<RouteSection> AffectedRoutes { get; set; }

        /// <summary>Gets or sets the stops affected by this disruption</summary>
        [Newtonsoft.Json.JsonProperty("affectedStops", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<StopPoint> AffectedStops { get; set; }

        [Newtonsoft.Json.JsonProperty("isBlocking", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsBlocking { get; set; }

        [Newtonsoft.Json.JsonProperty("isWholeLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsWholeLine { get; set; }

        [Newtonsoft.Json.JsonProperty("closureText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ClosureText { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Disruption FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Disruption>(data);
        }
    }
}

