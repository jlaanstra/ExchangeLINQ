using ExchangeLINQ.AccessTokens;
using ExchangeLINQ.Applications;
using ExchangeLINQ.AssociatedUsers;
using ExchangeLINQ.Common;
using ExchangeLINQ.Inbox;
using ExchangeLINQ.Sites;

namespace ExchangeLINQ.Context
{
	/// <summary>
	/// Implementation of the INetworkStackExchangeContext. For internal use only.
	/// </summary>
	internal class NetworkStackExchangeContext : INetworkStackExchangeContext
	{
		public string AccessToken { get; set; }

		public string Key { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="NetworkStackExchangeContext"/> class.
		/// </summary>
		/// <param name="apiKey">The API key.</param>
		internal NetworkStackExchangeContext(string key, string token)
		{
			this.AccessToken = token;
			this.Key = key;
		}

		/// <summary>
		/// Gets the access tokens endpoint.
		/// </summary>
		public AccessTokensEntry AccessTokens
		{
			get { return new AccessTokensEntry(new ExchangeUrl(this)); }
		}

		/// <summary>
		/// Gets the applications endpoint.
		/// </summary>
		public ApplicationsEntry Applications
		{
			get { return new ApplicationsEntry(new ExchangeUrl(this)); }
		}


		/// <summary>
		/// Gets the inbox endpoint.
		/// </summary>
		public InboxEntry Inbox
		{
			get { return new InboxEntry(new ExchangeUrl(this)); }
		}

		/// <summary>
		/// Gets the inbox endpoint.
		/// </summary>
		public AssociatedUsersEntry AssociatedUsers
		{
			get { return new AssociatedUsersEntry(new ExchangeUrl(this)); }
		}

		/// <summary>
		/// Gets the sites.
		/// </summary>
		public SitesEntry Sites
		{
			get { return new SitesEntry(new ExchangeUrl(this)); }
		}

	}
}
