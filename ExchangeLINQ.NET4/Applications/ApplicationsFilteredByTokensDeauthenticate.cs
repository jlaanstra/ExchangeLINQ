using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsFilteredByTokensDeauthenticate : ProcessorState<AccessToken>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SEApplicationsFilteredByTokensDeauthenticate"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal ApplicationsFilteredByTokensDeauthenticate(ExchangeUrl url, IEnumerable<string> tokens)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.DeauthenticateAppsByAccessTokensUrl, String.Join(";", tokens));
		}
	}
}
