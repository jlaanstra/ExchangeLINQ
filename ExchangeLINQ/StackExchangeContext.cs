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
		/// Creates a new instance of the IStackExchangeContext using the specified key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns></returns>
		public static IStackExchangeContext Create(string key)
		{
			return Create(key,string.Empty);
		}

		/// <summary>
		/// Creates a new instance of the IStackExchangeContext using the specified key and access token.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="accessToken">The access token.</param>
		/// <returns></returns>
		public static IStackExchangeContext Create(string key, string accessToken)
		{
			return new StackExchangeContextImpl(key, accessToken);
		}
	}
}
