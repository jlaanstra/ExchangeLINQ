using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using Newtonsoft.Json;

namespace ExchangeLINQ.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AccessToken
    {
        [JsonProperty("access_token")]
        public string Token { get; set; }

        [JsonProperty("expires_on_date")]
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime ExpiresOnDate { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("scope")]
        public IEnumerable<string> Scope { get; set; }
    }
}
