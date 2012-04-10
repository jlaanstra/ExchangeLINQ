using System;
using ExchangeLINQ.Common;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class MigrationInfo
	{
		[JsonProperty("question_id")]
		public int QuestionId { get; set; }
 
		[JsonProperty("other_site")]
		public Site OtherSite { get; set; }

		[JsonProperty("on_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime OnDate { get; set; }
	}
}
