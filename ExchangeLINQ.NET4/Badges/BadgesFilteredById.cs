using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	internal class BadgesFilteredById : ProcessorState<Badge>
	{
		private IEnumerable<int> ids;
		private IOAuth oauth;
		private string queryUrl = "/2.0/badges/{0}";

		/// <summary>
		/// Initializes a new instance of the <see cref="BadgesFilteredById"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		public BadgesFilteredById(IOAuth oauth,IEnumerable<int> ids)
		{
			this.oauth = oauth;
			this.ids = ids;
		}
	}
}
