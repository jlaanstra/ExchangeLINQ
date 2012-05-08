using System;
using ExchangeLINQ.AccessTokens;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsEntry : State
	{
		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public ApplicationsFilteredByTokens Where(Func<IApplicationsToken, FilterTokens> f)
		{
			FilterTokens tokens = f(new ApplicationsInterfacesImpl());
			return new ApplicationsFilteredByTokens() { Url = this.Url, Tokens = tokens };
		}
	}
}
