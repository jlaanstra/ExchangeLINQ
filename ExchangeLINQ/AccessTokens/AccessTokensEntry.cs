using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.AccessTokens
{
	public class AccessTokensEntry : State
	{
		/// <summary>
		/// Implements the Select query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AccessTokensFilteredByTokens Where(Func<InProp<FilterTokens,string>, FilterTokens> f)
		{
			FilterTokens t = f(new InProp<FilterTokens,string>());
			this.Url.QueryUrl = string.Format(UrlConstants.AccessTokensByNameUrl, String.Join(";", t.Value));
			return new AccessTokensFilteredByTokens() { Url = this.Url, Tokens = t };
		}
	}
}
