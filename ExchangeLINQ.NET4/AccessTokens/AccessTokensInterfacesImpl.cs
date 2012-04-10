using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.AccessTokens
{
	internal class AccessTokensInterfacesImpl : IAccessTokensPageInvalidate
	{
		public FilterInvalidate Invalidate { get { return new FilterInvalidate(); } }

		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }
	}
}
