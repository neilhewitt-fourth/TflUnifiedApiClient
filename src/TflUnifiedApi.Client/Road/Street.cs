using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Street
    {
        /// <summary>Street name</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>Type of road closure. Some example values:
        ///             Open = road is open, not blocked, not closed, not restricted. It maybe that the disruption has been moved out of the carriageway.
        ///             Partial Closure = road is privately blocked, closed or restricted. 
        ///             Full Closure = road is fully blocked or closed.</summary>
        [Newtonsoft.Json.JsonProperty("closure", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Closure { get; set; }

        /// <summary>The direction of the disruption on the street. Some example values:
        ///             All Directions
        ///             All Approaches
        ///             Clockwise
        ///             Anti-Clockwise
        ///             Northbound
        ///             Eastbound
        ///             Southbound
        ///             Westbound
        ///             Both Directions</summary>
        [Newtonsoft.Json.JsonProperty("directions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Directions { get; set; }

        /// <summary>Geographic description of the sections of this street that are affected.</summary>
        [Newtonsoft.Json.JsonProperty("segments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<StreetSegment> Segments { get; set; }

        /// <summary>The ID from the source system of the disruption that this street belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("sourceSystemId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SourceSystemId { get; set; }

        /// <summary>The key of the source system of the disruption that this street belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("sourceSystemKey", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSystemKey { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Street FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Street>(data);
        }
    }
}

