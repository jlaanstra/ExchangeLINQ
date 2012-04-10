using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
	[JsonObject(MemberSerialization.OptIn)]
	public class ResponseWrapper<T>
	{
		[JsonProperty("backoff")]
		public int Backoff { get; set; }

		[JsonProperty("error_id")]
		public int ErrorId { get; set; }

		[JsonProperty("error_message")]
		public string ErrorMessage { get; set; }

		[JsonProperty("error_name")]
		public string ErrorName { get; set; }

		[JsonProperty("has_more")]
		public bool HasMore { get; set; }

		[JsonProperty("page")]
		public int Page { get; set; }

		[JsonProperty("page_size")]
		public int PageSize { get; set; }

		[JsonProperty("quota_max")]
		public int QuotaMax { get; set; }

		[JsonProperty("quota_remaining")]
		public int QuotaRemaining { get; set; }

		[JsonProperty("total")]
		public int Total { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("items")]
		public IEnumerable<T> Items { get; set; }
	}
}
