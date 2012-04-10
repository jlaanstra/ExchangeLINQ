using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsFilteredByTokens : State
	{
		private IEnumerable<string> tokens;

		/// <summary>
		/// Initializes a new instance of the <see cref="SEApplicationsFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal ApplicationsFilteredByTokens(ExchangeUrl url,IEnumerable<string> tokens)
		{
			this.Url = url;
			this.tokens = tokens;
		}

		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="tokenSelector">The ids.</param>
		/// <returns></returns>
		public ApplicationsFilteredByTokensDeauthenticate Where(Action<IApplicationsDeauthenticate> tokenSelector)
		{
			return new ApplicationsFilteredByTokensDeauthenticate(this.Url, this.tokens);
		}
	}
}
