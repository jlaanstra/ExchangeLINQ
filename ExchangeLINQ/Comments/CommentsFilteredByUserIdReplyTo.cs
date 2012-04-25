using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	public class CommentsFilteredByUserIdReplyTo : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommentsFilteredById"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal CommentsFilteredByUserIdReplyTo(ExchangeUrl url, FilterUserIds ids, FilterToId toid)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.CommentsToUserIdByUserIdUrl, string.Join(";", ids.Value), toid.Value);
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
