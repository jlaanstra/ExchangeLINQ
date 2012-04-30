using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.AccessTokens
{
    public class AccessTokensEntry : State
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
        internal AccessTokensEntry(ExchangeUrl url)
        {
			this.Url = url;
        }

		/// <summary>
		/// Implements the Select query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
        public AccessTokensFilteredByTokens Where(Func<InProp<FilterTokens,string>, FilterTokens> f)
        {
            return new AccessTokensFilteredByTokens(this.Url, f(new InProp<FilterTokens,string>()));
        }
    }
}
