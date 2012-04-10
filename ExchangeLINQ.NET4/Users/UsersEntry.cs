using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Users
{
	public class UsersEntry : ProcessorState<User>
	{
		private IOAuth oauth;
		private ISite site;
		private string queryUrl = "";

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		public UsersEntry(IOAuth oauth, ISite site)
		{
			this.oauth = oauth;
			this.site = site;
		}
	}
}
