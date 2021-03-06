﻿namespace TflUnifiedApiClient
{
    public class DbGeographyWellKnownValue
    {
        [Newtonsoft.Json.JsonProperty("coordinateSystemId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CoordinateSystemId { get; set; }

        [Newtonsoft.Json.JsonProperty("wellKnownText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WellKnownText { get; set; }

        [Newtonsoft.Json.JsonProperty("wellKnownBinary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public byte[] WellKnownBinary { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static DbGeographyWellKnownValue FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DbGeographyWellKnownValue>(data);
        }
    }
}

