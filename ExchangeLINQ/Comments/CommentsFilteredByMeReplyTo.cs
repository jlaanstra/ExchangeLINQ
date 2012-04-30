using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Comments
{
	public class CommentsFilteredByMeReplyTo : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommentsFilteredByMeReplyTo"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="toid">The toid.</param>
		internal CommentsFilteredByMeReplyTo(ExchangeUrl url, FilterToId toid)
		{
			Contract.Requires(url != null);
			Contract.Requires(toid != null);

			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.CommentsToUserIdByMeUrl, toid);
		}

		#region Complex

		public FilteredByPage<Comment> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			return new FilteredByPage<Comment>(this.Url, f(new InterfacesImpl()));
		}

		public FilteredByFromDate<Comment> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			return new FilteredByFromDate<Comment>(this.Url, f(new InterfacesImpl()));
		}

		public FilteredByFilter<Comment> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			return new FilteredByFilter<Comment>(this.Url, f(new InterfacesImpl()));
		}

		#endregion

		#region OrderBy

		public OrderBy<Comment> OrderBy(Func<IOrderByCreationScore, FilterOrderBy> f)
		{
			return new OrderBy<Comment>(this.Url, f(new InterfacesImpl()));
		}

		public OrderByDescending<Comment> OrderByDescending(Func<IOrderByCreationScore, FilterOrderBy> f)
		{
			return new OrderByDescending<Comment>(this.Url, f(new InterfacesImpl()));
		}

		#endregion
	}
}
