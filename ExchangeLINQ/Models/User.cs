
using Newtonsoft.Json;
using System;
namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class User
	{
		[JsonProperty("about_me")]
		public string About { get; set; }

		[JsonProperty("accept_rate")]
		public int? AcceptRate { get; set; }

		[JsonProperty("account_id")]
		public int AccountId { get; set;}

		[JsonProperty("age")]
		public int? Age { get; set; }

		[JsonProperty("answer_count")]
		public int AnswerCount { get; set; }

		[JsonProperty("badge_counts")]
		public Badges Badges { get; set; }

		[JsonProperty("creation_date")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("display_name")]
		public string Name { get; set; }
		
		[JsonProperty("down_vote_count")]
		public int DownVoteCount { get; set; }

		[JsonProperty("is_employee")]
		public bool IsEmployee { get; set;}

		[JsonProperty("last_access_date")]
		public DateTime LastAccessDate { get; set; }

		[JsonProperty("last_modified_date")]
		public DateTime? LastModifiedDate { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("location")]
		public string Location { get; set; }

		[JsonProperty("profile_image")]
		public string ProfileImage { get; set; }

		[JsonProperty("question_count")]
		public int QuestionCount { get; set; }

		[JsonProperty("reputation")]
		public int Reputation { get; set; }

		[JsonProperty("reputation_change_day")]
		public int ReputationChangeDay { get; set; }

		[JsonProperty("reputation_change_month")]
		public int ReputationChangeMonth { get; set; }

		[JsonProperty("reputation_change_quarter")]
		public int ReputationChangeQuarter { get; set; }

		[JsonProperty("reputation_change_week")]
		public int ReputationChangeWeek { get; set; }

		[JsonProperty("reputation_change_year")]
		public int ReputationChangeYear { get; set; }

		[JsonProperty("timed_penalty_date")]
		public DateTime? TimedPenaltyDate { get; set; }

		[JsonProperty("up_vote_count")]
		public int UpVoteCount { get; set; }

		[JsonProperty("user_id")]
		public int UserId { get; set; }

		[JsonProperty("user_type")]
		public UserType UserType { get; set; }

		[JsonProperty("view_count")]
		public int ViewCount { get; set; }

		[JsonProperty("website_url")]
		public string WebsiteUrl { get; set; }
	}
}
