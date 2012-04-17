using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class Question
	{
		[JsonProperty("question_id")]
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

		[JsonProperty("answer_count")]
		public int AnswerCount { get; set; }

		[JsonProperty("accepted_answer_id")]
		public int? AcceptedAnswerId { get; set; }

		[JsonProperty("migrated_to")]
		public MigrationInfo MigratedTo { get; set; }

		[JsonProperty("migrated_from")]
		public MigrationInfo MigratedFrom { get; set; }

		[JsonProperty("bounty_closes_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? BountyClosesDate { get; set; }

		[JsonProperty("bounty_amount")]
		public int? BountyAmount { get; set; }

		[JsonProperty("closed_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? ClosedDate { get; set; }

		[JsonProperty("protected_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? ProtectedDate { get; set; }

		[JsonProperty("body")]
		public string Body { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("tags")]
		public IEnumerable<string> Tags { get; set;}

		[JsonProperty("closed_reason")]
		public string ClosedReason { get; set; }

		[JsonProperty("up_vote_count")]
		public int UpVoteCount { get; set; }

		[JsonProperty("down_vote_count")]
		public int DownVoteCount { get; set; }

		[JsonProperty("favorite_count")]
		public int FavoriteCount { get; set; }

		[JsonProperty("view_count")]
		public int ViewCount { get; set; }

		[JsonProperty("owner")]
		public ShallowUser User { get; set; }

		[JsonProperty("comments")]
		public IEnumerable<Comment> Comments { get; set; }

		[JsonProperty("answers")]
		public IEnumerable<Answer> Answers { get; set; }

		[JsonProperty("link")]
		public string Url { get; set; }

		[JsonProperty("is_answered")]
		public bool IsAnswered { get; set; }
	}
}
