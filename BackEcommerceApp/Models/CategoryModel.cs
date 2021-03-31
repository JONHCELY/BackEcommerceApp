using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BackEcommerceApp.Models
{
    public class CategoryModel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<CategoryModel> Children { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("MetaTagDescription")]
        public string MetaTagDescription { get; set; }
    }
}
