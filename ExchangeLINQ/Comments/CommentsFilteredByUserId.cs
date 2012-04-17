using System;
using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	internal class CommentsFilteredByUserId : ProcessorState<Answer>
	{
		private IEnumerable<int> ids;
		private string queryUrl = "/2.0/users/{ids}/comments";
		private IOAuth oauth;
		private ISite site;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		public CommentsFilteredByUserId(IOAuth oauth, ISite site, IEnumerable<int> ids)
		{
			this.oauth = oauth;
			this.site = site;
			this.ids = ids;
		}

		public CommentsFilteredByUserIdReplyTo Where(Func<ICommentsReplyToUser, int> f)
		{
			return new CommentsFilteredByUserIdReplyTo(oauth, site, ids, f(new CommentsInterfacesImpl()));
		}
	}
}
