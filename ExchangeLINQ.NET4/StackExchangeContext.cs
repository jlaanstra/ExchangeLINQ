using ExchangeLINQ.Context;

namespace ExchangeLINQ
{
	public class StackExchangeContext
	{
		//this makes instantiation impossible, which is what we want 
		private StackExchangeContext()
		{        
		}

		/// <summary>
		/// Returns a new instance of the INetworkStackExchangeContext.
		/// </summary>
		/// <param name="apiKey">The API key.</param>
		/// <returns></returns>
		public static INetworkStackExchangeContext Create(string key)
		{
			return Create(key,string.Empty);
		}

		/// <summary>
		/// Returns a new instance of the INetworkStackExchangeContext using the specified api key for authentication.
		/// </summary>
		/// <param name="apiKey">The API key.</param>
		/// <returns></returns>
		public static INetworkStackExchangeContext Create(string key, string accessToken)
		{
			return new NetworkStackExchangeContext(key, accessToken);
		}

		/// <summary>
		/// Returns an instance of a ISiteSpecificStackExchangeContext for the site specified by siteUri using the specified api key for authentication.
		/// </summary>
		/// <param name="apiKey">The API key.</param>
		/// <param name="siteUri">The site URI.</param>
		/// <returns></returns>
		public static ISiteStackExchangeContext CreateSiteSpecific(string key, string apiSiteParameter)
		{
			return CreateSiteSpecific(key, string.Empty, apiSiteParameter);
		}

		/// <summary>
		/// Returns an instance of a ISiteSpecificStackExchangeContext for the site specified by siteUri using the specified api key for authentication.
		/// </summary>
		/// <param name="apiKey">The API key.</param>
		/// <param name="siteUri">The site URI.</param>
		/// <returns></returns>
		public static ISiteStackExchangeContext CreateSiteSpecific(string key, string accessToken, string apiSiteParameter)
		{
			return new SiteStackExchangeContext(key, accessToken, apiSiteParameter);
		}
	}
}
