using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsFilteredByTokens : State
	{
		public FilterTokens Tokens { get; set; }
		
		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public ApplicationsFilteredByTokensDeauthenticate Where(Func<IApplicationsDeauthenticate, FilterDeauthenticate> f)
		{
			this.Url.QueryUrl = string.Format(UrlConstants.DeauthenticateAppsByAccessTokensUrl, String.Join(";", Tokens));
			return new ApplicationsFilteredByTokensDeauthenticate() { Url = this.Url };
		}
	}
}
