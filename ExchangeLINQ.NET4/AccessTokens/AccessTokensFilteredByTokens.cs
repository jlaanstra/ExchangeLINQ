using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AccessTokens
{
	public class AccessTokensFilteredByTokens : ProcessorState<AccessToken>
	{
		private FilterTokens tokens;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal AccessTokensFilteredByTokens(ExchangeUrl url, FilterTokens tokens)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.AccessTokensByNameUrl, String.Join(";", tokens.Value));

			this.tokens = tokens;
		}

		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="tokenSelector">The ids.</param>
		/// <returns></returns>
		public AccessTokensFilteredByTokensInvalidate Where(Func<IAccessTokensPageInvalidate, FilterInvalidate> tokenSelector)
		{
			return new AccessTokensFilteredByTokensInvalidate(this.Url, this.tokens);
		}

		public FilteredByPage<AccessToken> Where(Func<IAccessTokensPageInvalidate, FilterPage> f)
		{
			FilterPage filter = f(new AccessTokensInterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
