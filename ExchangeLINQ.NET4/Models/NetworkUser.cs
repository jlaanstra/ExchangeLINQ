using System;
using ExchangeLINQ.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class NetworkUser
	{
		[JsonProperty("site_name")]
		public string SiteName { get; set; }

		[JsonProperty("site_url")]
		public string SiteUrl { get; set; }

		[JsonProperty("user_id")]
		public int UserId { get; set; }

		[JsonProperty("reputation")]
		public int Reputation { get; set; }

		[JsonProperty("account_id")]
		public int AccountId { get; set; }

		/// <summary>
		/// Gets or sets the creation date in UTC.
		/// </summary>
		/// <value>
		/// The creation date.
		/// </value>
		[JsonProperty("creation_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime CreationDate { get; set; }
 
		/// <summary>
		/// Gets or sets the type of the user.
		/// one of unregistered, registered, moderator, or does_not_exist
		/// </summary>
		/// <value>
		/// The type of the user.
		/// </value>
		[JsonProperty("user_type")]
		[JsonConverter(typeof(StringEnumConverter))]
		public UserType UserType { get; set; }

		[JsonProperty("badge_counts")]
		public Badges Badges { get; set; }

		/// <summary>
		/// Gets or sets the last access date in UTC.
		/// </summary>
		/// <value>
		/// The last access date.
		/// </value>
		[JsonProperty("last_access_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime LastAccessDate { get; set; }

		[JsonProperty("answer_count")]
		public int AnswerCount { get; set; }

		[JsonProperty("question_count")]
		public int QuestionCount { get; set; }
	}
}
