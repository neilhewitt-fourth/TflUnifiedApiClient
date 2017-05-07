using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class StopPoint
    {
        [Newtonsoft.Json.JsonProperty("naptanId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NaptanId { get; set; }

        [Newtonsoft.Json.JsonProperty("platformName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlatformName { get; set; }

        /// <summary>The indicator of the stop point e.g. "Stop K"</summary>
        [Newtonsoft.Json.JsonProperty("indicator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Indicator { get; set; }

        /// <summary>The stop letter, if it could be cleansed from the Indicator e.g. "K"</summary>
        [Newtonsoft.Json.JsonProperty("stopLetter", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StopLetter { get; set; }

        [Newtonsoft.Json.JsonProperty("modes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<string> Modes { get; set; }

        [Newtonsoft.Json.JsonProperty("icsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IcsCode { get; set; }

        [Newtonsoft.Json.JsonProperty("smsCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SmsCode { get; set; }

        [Newtonsoft.Json.JsonProperty("stopType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StopType { get; set; }

        [Newtonsoft.Json.JsonProperty("stationNaptan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationNaptan { get; set; }

        [Newtonsoft.Json.JsonProperty("accessibilitySummary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccessibilitySummary { get; set; }

        [Newtonsoft.Json.JsonProperty("hubNaptanCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HubNaptanCode { get; set; }

        [Newtonsoft.Json.JsonProperty("lines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Identifier> Lines { get; set; }

        [Newtonsoft.Json.JsonProperty("lineGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<LineGroup> LineGroup { get; set; }

        [Newtonsoft.Json.JsonProperty("lineModeGroups", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<LineModeGroup> LineModeGroups { get; set; }

        [Newtonsoft.Json.JsonProperty("fullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [Newtonsoft.Json.JsonProperty("naptanMode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NaptanMode { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Status { get; set; }

        /// <summary>A unique identifier.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The unique location of this resource.</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>A human readable name.</summary>
        [Newtonsoft.Json.JsonProperty("commonName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CommonName { get; set; }

        /// <summary>The distance of the place from its search point, if this is the result
        ///             of a geographical search, otherwise zero.</summary>
        [Newtonsoft.Json.JsonProperty("distance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        /// <summary>The type of Place. See /Place/Meta/placeTypes for possible values.</summary>
        [Newtonsoft.Json.JsonProperty("placeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlaceType { get; set; }

        /// <summary>A bag of additional key/value pairs with extra information about this place.</summary>
        [Newtonsoft.Json.JsonProperty("additionalProperties", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<AdditionalProperties> AdditionalProperties { get; set; }

        [Newtonsoft.Json.JsonProperty("children", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Place> Children { get; set; }

        [Newtonsoft.Json.JsonProperty("childrenUrls", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<string> ChildrenUrls { get; set; }

        /// <summary>WGS84 latitude of the location.</summary>
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        /// <summary>WGS84 longitude of the location.</summary>
        [Newtonsoft.Json.JsonProperty("lon", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lon { get; set; }

    }
}

