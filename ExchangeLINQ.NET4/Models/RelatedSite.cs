using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class RelatedSite
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("site_url")]
        public string SiteUrl { get; set; }

        [JsonProperty("relation")]
        public Relation Relation { get; set; }

        [JsonProperty("api_site_parameter")]
        public string ApiSiteParameter { get; set; }
    }
}
