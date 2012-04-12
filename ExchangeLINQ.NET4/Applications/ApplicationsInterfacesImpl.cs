using System;
using System.Collections.Generic;
using System.Linq;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsInterfacesImpl : IApplicationsDeauthenticate, IApplicationsToken
	{
		/// <summary>
		/// Deauthenticates this instance.
		/// </summary>
		public FilterDeauthenticate Deauthenticate { get { return new FilterDeauthenticate(); } }

		/// <summary>
		/// Gets or sets the token.
		/// </summary>
		/// <value>
		/// The token.
		/// </value>
		public InProp<FilterTokens, string> Token { get { return new InProp<FilterTokens,string>(); } }        
	}
}
