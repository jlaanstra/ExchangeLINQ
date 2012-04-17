using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsFilteredByTokensDeauthenticate : ProcessorState<AccessToken>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SEApplicationsFilteredByTokensDeauthenticate"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal ApplicationsFilteredByTokensDeauthenticate(ExchangeUrl url, FilterTokens tokens)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.DeauthenticateAppsByAccessTokensUrl, String.Join(";", tokens));
		}

		public FilteredByPage<AccessToken> Where(Func<IPage, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
