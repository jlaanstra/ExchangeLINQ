using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Site
	{
		[JsonProperty("site_type")]
		public string Type { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("logo_url")]
		public string LogoUrl { get; set; }

		[JsonProperty("api_site_parameter")]
		public string ApiSiteParameter { get; set; }

		[JsonProperty("site_url")]
		public string SiteUrl { get; set; }

		[JsonProperty("audience")]
		public string Audience { get; set; }

		[JsonProperty("icon_url")]
		public string IconUrl { get; set; }

		[JsonProperty("aliases")]
		public IEnumerable<string> Aliases { get; set; }

		[JsonProperty("site_state")]
		[JsonConverter(typeof(StringEnumConverter))]
		public SiteState State { get; set; }

		[JsonProperty("styling")]
		public Styling Styling { get; set; }

		[JsonProperty("closed_beta_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime ClosedBetaDate { get; set; }

		[JsonProperty("open_beta_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime OpenBetaDate { get; set; }

		[JsonProperty("launch_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime LaunchDate { get; set; }

		[JsonProperty("favicon_url")]
		public string FaviconUrl { get; set; }

		[JsonProperty("related_sites")]
		public IEnumerable<RelatedSite> RelatedSites { get; set; }

		[JsonProperty("twitter_account")]
		public string TwitterAccount { get; set; }

		[JsonProperty("markdown_extensions")]
		public IEnumerable<string> MarkdownExtensions { get; set; }
	}
}
