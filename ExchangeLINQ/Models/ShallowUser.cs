using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class ShallowUser
	{
		[JsonProperty("user_id")]
		public int Id { get; set; }

		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[JsonProperty("reputation")]
		public int Reputation { get; set; }

		[JsonProperty("user_type")]
		[JsonConverter(typeof(StringEnumConverter))]
		public UserType Type { get; set; }

		[JsonProperty("profile_image")]
		public string Image { get; set; }

		[JsonProperty("link")]
		public string Url { get; set; }

		[JsonProperty("accept_rate")]
		public int AcceptRate { get; set; }
	}
}
