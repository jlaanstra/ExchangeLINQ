using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ExchangeLINQ.Context;

#if SILVERLIGHT && !WINDOWS_PHONE
using System.Windows.Browser;
#endif
#if !SILVERLIGHT
using System.Web;
#endif

namespace ExchangeLINQ.Common
{
	internal class ExchangeUrl
	{
		private IOAuth oauth;
		private IList<string> options;

		public ExchangeUrl(IOAuth oauth)
		{
			this.oauth = oauth;
			this.options = new List<string>();
		}

		public void AddQueryOption(string name, string value)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}

			this.options.Add(HttpUtility.UrlEncode(name) + "=" + HttpUtility.UrlEncode(value));
		}

		public void RemoveQueryOption(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}

			for (int i = 0; i < options.Count; i++)
			{
				if (options[i].StartsWith(name))
				{
					options.RemoveAt(i);
					break;
				}
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append(UrlConstants.BaseUrl);
			sb.Append(this.QueryUrl);
			sb.Append("?");
			sb.Append("key=");
			sb.Append(oauth.Key);
			if (!string.IsNullOrEmpty(oauth.AccessToken))
			{
				sb.Append("&access_token=");
				sb.Append(oauth.AccessToken);
			}
			foreach (string option in this.options)
			{
				sb.Append("&");
				sb.Append(option);
			}
			return sb.ToString();
		}

		public string QueryUrl { get; set; }
	}
}
