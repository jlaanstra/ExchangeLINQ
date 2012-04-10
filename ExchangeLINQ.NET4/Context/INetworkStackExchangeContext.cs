using ExchangeLINQ.AccessTokens;
using ExchangeLINQ.Applications;
using ExchangeLINQ.AssociatedUsers;
using ExchangeLINQ.Inbox;
using ExchangeLINQ.Sites;

namespace ExchangeLINQ.Context
{
	public interface INetworkStackExchangeContext : IOAuth
	{
		AccessTokensEntry AccessTokens { get; }

		ApplicationsEntry Applications { get; }

		InboxEntry Inbox { get; }

		AssociatedUsersEntry AssociatedUsers { get; }

		SitesEntry Sites { get; }
	}
}
