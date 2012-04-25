using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Models
{
	/// <summary>
	/// Represent a tag object from the Stack Exchange API.
	/// </summary>
	[JsonObject(MemberSerialization.OptIn)]
	public class Tag
	{
		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>
		/// The count.
		/// </value>
		[JsonProperty("count")]
		public int Count { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance has synonyms.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance has synonyms; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("has_synonyms")]
		public bool HasSynonyms { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is moderator only.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is moderator only; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("is_moderator_only")]
		public bool IsModeratorOnly { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is required.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is required; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("is_required")]
		public bool IsRequired { get; set; }

		/// <summary>
		/// Gets or sets the last activity date.
		/// </summary>
		/// <value>
		/// The last activity date. May be absent.
		/// </value>
		[JsonProperty("last_activity_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime? LastActivityDate { get; set;}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the user id.
		/// </summary>
		/// <value>
		/// The user id. May be absent.
		/// </value>
		[JsonProperty("user_id")]
		public int? UserId { get; set; }
	}
}
