using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Badges
	{
		[JsonProperty("gold")]
		public int Gold { get; set; }

		[JsonProperty("silver")]
		public int Silver { get; set; }

		[JsonProperty("bronze")]
		public int Bronze { get; set; }
	}
}
