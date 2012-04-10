using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	internal class BadgesEntry : ProcessorState<Badge>
	{
		private IOAuth oauth;
		private ISite site;
		private string queryUrl = "/2.0/badges";

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		public BadgesEntry(IOAuth oauth, ISite site)
		{
			this.oauth = oauth;
			this.site = site;
		}
	}
}
