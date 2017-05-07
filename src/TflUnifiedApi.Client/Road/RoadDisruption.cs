using System;
using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class RoadDisruption
    {
        /// <summary>Unique identifier for the road disruption</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>URL to retrieve this road disruption</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>Latitude and longitude (WGS84) of the centroid of the disruption, stored in a geoJSON-formatted string.</summary>
        [Newtonsoft.Json.JsonProperty("point", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Point { get; set; }

        /// <summary>A description of the severity of the disruption.</summary>
        [Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Severity { get; set; }

        /// <summary>An ordinal of the disruption based on severity, level of interest and corridor.</summary>
        [Newtonsoft.Json.JsonProperty("ordinal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Ordinal { get; set; }

        /// <summary>Describes the nature of disruption e.g. Traffic Incidents, Works</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>Describes the sub-category of disruption e.g. Collapsed Manhole, Abnormal Load</summary>
        [Newtonsoft.Json.JsonProperty("subCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubCategory { get; set; }

        /// <summary>Full text of comments describing the disruption, including details of any road closures and diversions, where appropriate.</summary>
        [Newtonsoft.Json.JsonProperty("comments", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Comments { get; set; }

        /// <summary>Text of the most recent update from the LSTCC on the state of the
        ///              disruption, including the current traffic impact and any advice to
        ///              road users.</summary>
        [Newtonsoft.Json.JsonProperty("currentUpdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrentUpdate { get; set; }

        /// <summary>The time when the last CurrentUpdate description was recorded, 
        ///             or null if no CurrentUpdate has been applied.</summary>
        [Newtonsoft.Json.JsonProperty("currentUpdateDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? CurrentUpdateDateTime { get; set; }

        /// <summary>The IDs of affected corridors, if any.</summary>
        [Newtonsoft.Json.JsonProperty("corridorIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<string> CorridorIds { get; set; }

        /// <summary>The date and time which the disruption started. For a planned disruption (i.e. planned road works) this date will be in the future.
        ///             For unplanned disruptions, this will default to the date on which the disruption was first recorded, but may be adjusted by the operator.</summary>
        [Newtonsoft.Json.JsonProperty("startDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>The date and time on which the disruption ended. For planned disruptions, this date will have a valid value. For unplanned 
        ///             disruptions in progress, this field will be omitted.</summary>
        [Newtonsoft.Json.JsonProperty("endDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>The date and time on which the disruption was last modified in the system. This information can reliably be used by a developer to quickly
        ///             compare two instances of the same disruption to determine if it has been changed.</summary>
        [Newtonsoft.Json.JsonProperty("lastModifiedTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>This describes the level of potential impact on traffic operations of the disruption. 
        ///             High = e.g. a one-off disruption on a major or high profile route which will require a high level of operational attention 
        ///             Medium = This is the default value 
        ///             Low = e.g. a frequently occurring disruption which is well known</summary>
        [Newtonsoft.Json.JsonProperty("levelOfInterest", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LevelOfInterest { get; set; }

        /// <summary>Main road name / number (borough) or preset area name where the disruption is located. This might be useful for a map popup where space is limited.</summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>This describes the status of the disruption.  
        ///             Active = currently in progress 
        ///             Active Long Term = currently in progress and long term
        ///             Scheduled = scheduled to start within the next 180 days
        ///             Recurring Works = planned maintenance works that follow a regular routine or pattern and whose next occurrence is to start within the next 180 days.
        ///             Recently Cleared = recently cleared in the last 24 hours
        ///             Note that the status of Scheduled or Recurring Works disruptions will change to Active when they start, and will change status again when they end.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>Geography version of Point for output as GeoJSON.
        ///             Can not use Geometry in a consistent way as non-TIMS disruptions do not have a polygon</summary>
        [Newtonsoft.Json.JsonProperty("geography", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DbGeography Geography { get; set; }

        /// <summary>GeoJSON formatted latitude/longitude (WGS84) pairs forming an enclosed polyline or polygon. The polygon will only be included where affected streets information
        ///             is not available for the disruption, would be inappropriate (e.g. a very large number of streets), or is centred on an area without streets (e.g. a football stadium).</summary>
        [Newtonsoft.Json.JsonProperty("geometry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DbGeography Geometry { get; set; }

        /// <summary>A collection of zero or more streets affected by the disruption.</summary>
        [Newtonsoft.Json.JsonProperty("streets", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<Street> Streets { get; set; }

        /// <summary>True if the disruption is planned on a future date that is open to change</summary>
        [Newtonsoft.Json.JsonProperty("isProvisional", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsProvisional { get; set; }

        /// <summary>True if any of the affected Streets have a "Full Closure" status, false otherwise. A RoadDisruption that has HasClosures is considered a 
        ///             Severe or Serious disruption for severity filtering purposes.</summary>
        [Newtonsoft.Json.JsonProperty("hasClosures", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? HasClosures { get; set; }

        /// <summary>The text of any associated link</summary>
        [Newtonsoft.Json.JsonProperty("linkText", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LinkText { get; set; }

        /// <summary>The url of any associated link</summary>
        [Newtonsoft.Json.JsonProperty("linkUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LinkUrl { get; set; }

        /// <summary>Any associated road project</summary>
        [Newtonsoft.Json.JsonProperty("roadProject", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RoadProject RoadProject { get; set; }

        /// <summary>TDM Additional properties</summary>
        [Newtonsoft.Json.JsonProperty("publishStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? PublishStartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("publishEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? PublishEndDate { get; set; }

        [Newtonsoft.Json.JsonProperty("timeFrame", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeFrame { get; set; }

        [Newtonsoft.Json.JsonProperty("roadDisruptionLines", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<RoadDisruptionLine> RoadDisruptionLines { get; set; }

        [Newtonsoft.Json.JsonProperty("roadDisruptionImpactAreas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<RoadDisruptionImpactArea> RoadDisruptionImpactAreas { get; set; }

        [Newtonsoft.Json.JsonProperty("recurringSchedules", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<RoadDisruptionSchedule> RecurringSchedules { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RoadDisruption FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RoadDisruption>(data);
        }
    }
}

