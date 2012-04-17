using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AccessTokens
{
	public class AccessTokensFilteredByTokensInvalidate : ProcessorState<AccessToken>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal AccessTokensFilteredByTokensInvalidate(ExchangeUrl url, FilterTokens tokens)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.InvalidateAccessTokensByNameUrl, String.Join(";", tokens.Value));
		}

		public FilteredByPage<AccessToken> Where(Func<IPage, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
