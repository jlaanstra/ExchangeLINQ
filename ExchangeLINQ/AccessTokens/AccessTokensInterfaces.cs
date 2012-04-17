using ExchangeLINQ.Complex;

namespace ExchangeLINQ.AccessTokens
{
	public interface IAccessTokensPageInvalidate : IPage
	{
		FilterInvalidate Invalidate { get; }
	}
}
