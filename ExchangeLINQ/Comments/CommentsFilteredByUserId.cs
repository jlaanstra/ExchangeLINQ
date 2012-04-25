using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	public class CommentsFilteredByUserId : ProcessorState<Answer>
	{
		private FilterUserIds ids;

		/// <summary>
		/// Initializes a new instance of the <see cref="CommentsFilteredById"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal CommentsFilteredByUserId(ExchangeUrl url, FilterUserIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.CommentsByUserIdUrl, string.Join(";", ids.Value));

			this.ids = ids;
		}

		public CommentsFilteredByUserIdReplyTo Where(Func<ICommentsReplyToUserPageFromDateFilter, FilterToId> f)
		{
			return new CommentsFilteredByUserIdReplyTo(this.Url, ids, f(new CommentsInterfacesImpl()));
		}
	}
}
