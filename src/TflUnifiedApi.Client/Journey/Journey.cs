using System;
using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    /// <summary>Object that represents an end to end journey (see schematic).</summary>

    public class Journey
    {
        [Newtonsoft.Json.JsonProperty("startDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? StartDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        [Newtonsoft.Json.JsonProperty("arrivalDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ArrivalDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("legs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Leg> Legs { get; set; }

    }
}

