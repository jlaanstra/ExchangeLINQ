using System;
using ExchangeLINQ.AccessTokens;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Applications
{
	public class ApplicationsEntry : State
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApplicationsEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal ApplicationsEntry(ExchangeUrl url)
		{
			this.Url = url;
		}

		/// <summary>
		/// Helper function to filter tokens based on a set of ids.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public ApplicationsFilteredByTokens Where(Func<IApplicationsToken, FilterTokens> f)
		{
			return new ApplicationsFilteredByTokens(this.Url, f(new ApplicationsInterfacesImpl()));
		}
	}
}
