using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Badge
	{
		[JsonProperty("badge_id")]
		public int BadgeId { get; set; } 

		[JsonProperty("rank")]
		public string Rank { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("award_count")]
		public int AwardCount { get; set; }

		[JsonProperty("badge_type")]
		public string BadgeType { get; set; }

		[JsonProperty("shallow_user")]
		public ShallowUser ShallowUser { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
