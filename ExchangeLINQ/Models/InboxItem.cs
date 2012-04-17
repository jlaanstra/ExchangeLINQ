using System;
using ExchangeLINQ.Common;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class InboxItem
	{
		/// <summary>
		/// Gets or sets the type, one of comment, chat_message, new_answer, careers_message, careers_invitations, or meta_question
		/// </summary>
		/// <value>
		/// The type.
		/// </value>
		/// <remarks>
		/// Originally this was an enum but as noted on https://api.stackexchange.com/docs/types/inbox-item
		/// the types are subject to change so strings are a better fit for this.
		/// </remarks>
		[JsonProperty("item_type")]	
		//[JsonConverter(typeof(StringEnumConverter))] 
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the question id, refers to a question.
		/// </summary>
		/// <value>
		/// The question id.
		/// </value>
		[JsonProperty("question_id")]
		public int? QuestionId { get; set; }
 
		/// <summary>
		/// Gets or sets the answer id, refers to an answer.
		/// </summary>
		/// <value>
		/// The answer id.
		/// </value>
		[JsonProperty("answer_id")]
		public int? AnswerId { get; set; }

		/// <summary>
		/// Gets or sets the comment id, refers to a comment.
		/// </summary>
		/// <value>
		/// The comment id.
		/// </value>
		[JsonProperty("comment_id")]
		public int? CommentId { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>
		/// The title.
		/// </value>
		[JsonProperty("title")]
		[JsonConverter(typeof(HtmlDecodeConverter))]
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the date.
		/// </summary>
		/// <value>
		/// The date.
		/// </value>
		[JsonProperty("creation_date")]
		[JsonConverter(typeof(UnixTimestampConverter))]
		public DateTime Date { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is unread.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is unread; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("is_unread")]
		public bool IsUnread { get; set; }

		/// <summary>
		/// Gets or sets the site.
		/// </summary>
		/// <value>
		/// The site.
		/// </value>
		[JsonProperty("site")]
		public Site Site { get; set; }

		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		/// <value>
		/// The body.
		/// </value>
		[JsonProperty("body")]
		[JsonConverter(typeof(HtmlDecodeConverter))]
		public string Body { get; set;}

		/// <summary>
		/// Gets or sets the URL.
		/// </summary>
		/// <value>
		/// The URL.
		/// </value>
		[JsonProperty("link")]
		public string Url { get; set; }
	}
}
