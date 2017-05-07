using System;

namespace TflUnifiedApiClient
{
    /// <summary>DTO to capture the prediction details</summary>

    public class Prediction
    {
        /// <summary>The identitier for the prediction</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>The type of the operation (1: is new or has been updated, 2: should be deleted from any client cache)</summary>
        [Newtonsoft.Json.JsonProperty("operationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? OperationType { get; set; }

        /// <summary>The actual vehicle in transit (for train modes, the leading car of the rolling set)</summary>
        [Newtonsoft.Json.JsonProperty("vehicleId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleId { get; set; }

        /// <summary>Identifier for the prediction</summary>
        [Newtonsoft.Json.JsonProperty("naptanId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NaptanId { get; set; }

        /// <summary>Station name</summary>
        [Newtonsoft.Json.JsonProperty("stationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StationName { get; set; }

        /// <summary>Unique identifier for the Line</summary>
        [Newtonsoft.Json.JsonProperty("lineId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineId { get; set; }

        /// <summary>Line Name</summary>
        [Newtonsoft.Json.JsonProperty("lineName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LineName { get; set; }

        /// <summary>Platform name (for bus, this is the stop letter)</summary>
        [Newtonsoft.Json.JsonProperty("platformName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlatformName { get; set; }

        /// <summary>Direction (unified to inbound/outbound)</summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>Bearing (between 0 to 359)</summary>
        [Newtonsoft.Json.JsonProperty("bearing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bearing { get; set; }

        /// <summary>Naptan Identifier for the prediction's destination</summary>
        [Newtonsoft.Json.JsonProperty("destinationNaptanId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationNaptanId { get; set; }

        /// <summary>Name of the destination</summary>
        [Newtonsoft.Json.JsonProperty("destinationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DestinationName { get; set; }

        /// <summary>Timestamp for when the prediction was inserted/modified (source column drives what objects are broadcast on each iteration)</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? Timestamp { get; set; }

        /// <summary>Prediction of the Time to station in seconds</summary>
        [Newtonsoft.Json.JsonProperty("timeToStation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TimeToStation { get; set; }

        /// <summary>The current location of the vehicle.</summary>
        [Newtonsoft.Json.JsonProperty("currentLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrentLocation { get; set; }

        /// <summary>Routing information or other descriptive text about the path of the vehicle towards the destination</summary>
        [Newtonsoft.Json.JsonProperty("towards", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Towards { get; set; }

        /// <summary>The expected arrival time of the vehicle at the stop/station</summary>
        [Newtonsoft.Json.JsonProperty("expectedArrival", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ExpectedArrival { get; set; }

        /// <summary>The expiry time for the prediction</summary>
        [Newtonsoft.Json.JsonProperty("timeToLive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? TimeToLive { get; set; }

        /// <summary>The mode name of the station/line the prediction relates to</summary>
        [Newtonsoft.Json.JsonProperty("modeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeName { get; set; }

        /// <summary>Keep the original timestamp from MongoDb fo debugging purposes</summary>
        [Newtonsoft.Json.JsonProperty("timing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PredictionTiming Timing { get; set; }

    }
}

