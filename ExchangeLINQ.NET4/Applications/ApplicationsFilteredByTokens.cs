using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.AccessTokens;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsFilteredByTokens : State
	{
		private FilterTokens tokens;

		/// <summary>
		/// Initializes a new instance of the <see cref="SEApplicationsFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal ApplicationsFilteredByTokens(ExchangeUrl url, FilterTokens tokens)
		{
			this.Url = url;
			this.tokens = tokens;
		}

		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="tokenSelector">The ids.</param>
		/// <returns></returns>
		public ApplicationsFilteredByTokensDeauthenticate Where(Func<IApplicationsDeauthenticate, FilterDeauthenticate> f)
		{
			return new ApplicationsFilteredByTokensDeauthenticate(this.Url, this.tokens);
		}
	}
}
