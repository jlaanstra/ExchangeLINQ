using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	internal class CommentsFilteredByUserIdReplyTo : ProcessorState<Answer>
	{
		private IEnumerable<int> ids;
		private int toid;
		private string queryUrl = "/2.0/users/{ids}/comments/{toid}";
		private IOAuth oauth;
		private ISite site;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		public CommentsFilteredByUserIdReplyTo(IOAuth oauth, ISite site, IEnumerable<int> ids, int toid)
		{
			this.oauth = oauth;
			this.site = site;
			this.ids = ids;
			this.toid = toid;
		}
	}
}
