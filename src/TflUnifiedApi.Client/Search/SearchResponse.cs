﻿using System.Collections.ObjectModel;

namespace TflUnifiedApiClient
{
    public class SearchResponse
    {
        [Newtonsoft.Json.JsonProperty("query", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Query { get; set; }

        [Newtonsoft.Json.JsonProperty("from", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? From { get; set; }

        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page { get; set; }

        [Newtonsoft.Json.JsonProperty("pageSize", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        [Newtonsoft.Json.JsonProperty("provider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Provider { get; set; }

        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total { get; set; }

        [Newtonsoft.Json.JsonProperty("matches", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ObservableCollection<SearchMatch> Matches { get; set; }

        [Newtonsoft.Json.JsonProperty("maxScore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxScore { get; set; }

        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static SearchResponse FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResponse>(data);
        }
    }
}

