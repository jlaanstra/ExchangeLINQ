using System;
using ExchangeLINQ.Common;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Comment
	{
		[JsonProperty("comment_id")]
		public int ID { get; set; }

		[JsonProperty("post_id")]
		public int PostID { get; set; }

		[JsonProperty("creation_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime CreationDate { get; set; }

		[JsonProperty("post_type")]
		public PostType Type { get; set; }

		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("edited")]
		public bool Edited { get; set; }

		[JsonProperty("body")]
		public string Body { get; set; }

		[JsonProperty("owner")]
		public ShallowUser User { get; set; }
		
		[JsonProperty("reply_to_user")]
		public ShallowUser ReplyToUser { get; set; }

		[JsonProperty("link")]
		public string Url { get; set; }
	}
}
