using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Answer
	{
		[JsonProperty("question_id")]
		public int QuestionID { get; set; }

		[JsonProperty("answer_id")]
		public int ID { get; set; }

		[JsonProperty("last_edit_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? LastEditDate { get; set; }

		[JsonProperty("creation_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime CreationDate { get; set; }

		[JsonProperty("last_activity_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime LastActivityDate { get; set; }

		[JsonProperty("locked_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? LockedDate { get; set; }
		
		[JsonProperty("score")]
		public int Score { get; set; }

		[JsonProperty("community_owned_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? CommunityOwnedDate { get; set; }

		[JsonProperty("is_accepted")]
		public bool IsAnswered { get; set; }
		
		[JsonProperty("body")]
		public string Body { get; set; }

		[JsonProperty("up_vote_count")]
		public int UpVoteCount { get; set; }

		[JsonProperty("down_vote_count")]
		public int DownVoteCount { get; set; }

		[JsonProperty("owner")]
		public ShallowUser User { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	
		[JsonProperty("comments")]
		public IEnumerable<Comment> Comments { get; set; }
		
		[JsonProperty("link")]
		public string Url { get; set; }
	}
}
