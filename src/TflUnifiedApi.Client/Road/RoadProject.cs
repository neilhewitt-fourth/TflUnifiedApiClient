using System;
using System.Collections.Generic;

namespace TflUnifiedApiClient
{
    public class RoadProject
    {
        [Newtonsoft.Json.JsonProperty("projectId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        [Newtonsoft.Json.JsonProperty("schemeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SchemeName { get; set; }

        [Newtonsoft.Json.JsonProperty("projectName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        [Newtonsoft.Json.JsonProperty("projectDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectDescription { get; set; }

        [Newtonsoft.Json.JsonProperty("projectPageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectPageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("consultationPageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsultationPageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("consultationStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ConsultationStartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("consultationEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ConsultationEndDate { get; set; }

        [Newtonsoft.Json.JsonProperty("constructionStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ConstructionStartDate { get; set; }

        [Newtonsoft.Json.JsonProperty("constructionEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime? ConstructionEndDate { get; set; }

        [Newtonsoft.Json.JsonProperty("boroughsBenefited", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IEnumerable<string> BoroughsBenefited { get; set; }

        [Newtonsoft.Json.JsonProperty("cycleSuperhighwayId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CycleSuperhighwayId { get; set; }

        [Newtonsoft.Json.JsonProperty("phase", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoadProjectPhase? Phase { get; set; }

        [Newtonsoft.Json.JsonProperty("contactName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactName { get; set; }

        [Newtonsoft.Json.JsonProperty("contactEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactEmail { get; set; }

        [Newtonsoft.Json.JsonProperty("externalPageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalPageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("projectSummaryPageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProjectSummaryPageUrl { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static RoadProject FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<RoadProject>(data);
        }
    }
}

