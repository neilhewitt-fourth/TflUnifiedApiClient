using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class Place
    {
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

