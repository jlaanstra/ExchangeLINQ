using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AccessTokens
{
	public class AccessTokensFilteredByTokens : ProcessorState<AccessToken>
	{
		public FilterTokens Tokens { get; set; }

		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="tokenSelector">The ids.</param>
		/// <returns></returns>
		public AccessTokensFilteredByTokensInvalidate Where(Func<IAccessTokensPageInvalidate, FilterInvalidate> tokenSelector)
		{
			this.Url.QueryUrl = string.Format(UrlConstants.InvalidateAccessTokensByNameUrl, String.Join(";", Tokens.Value));
			return new AccessTokensFilteredByTokensInvalidate() { Url = this.Url };
		}

		public FilteredByPage<AccessToken> Where(Func<IAccessTokensPageInvalidate, FilterPage> f)
		{
			FilterPage filter = f(new AccessTokensInterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
