using System;
using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	internal class CommentsEntry : ProcessorState<Comment>
	{
		private IOAuth oauth;
		private ISite site;
		private string queryUrl = "";

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		public CommentsEntry(IOAuth oauth, ISite site)
		{
			this.oauth = oauth;
			this.site = site;
		}

		public CommentsFilteredById Where(Func<ICommentsId, IEnumerable<int>> f)
		{
			return new CommentsFilteredById(oauth, site, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByQuestionId Where(Func<ICommentsQuestion, IEnumerable<int>> f)
		{
			return new CommentsFilteredByQuestionId(oauth, site, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByUserId Where(Func<ICommentsPostingUser, IEnumerable<int>> f)
		{
			return new CommentsFilteredByUserId(oauth, site, f(new CommentsInterfacesImpl()));
		}
	}
}
