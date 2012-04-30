using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Comments
{
	public class CommentsFilteredByMe : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommentsFilteredByMe"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal CommentsFilteredByMe(ExchangeUrl url)
		{
			Contract.Requires(url != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.CommentsByMeUrl;
		}

		public CommentsFilteredByMeReplyTo Where(Func<ICommentsReplyToUserPageFromDateFilter, FilterToId> f)
		{
			return new CommentsFilteredByMeReplyTo(this.Url, f(new CommentsInterfacesImpl()));
		}
	}
}
