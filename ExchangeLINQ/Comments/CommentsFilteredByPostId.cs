using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	public class CommentsFilteredByPostId : ProcessorState<Comment>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommentsFilteredByPostId"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal CommentsFilteredByPostId(ExchangeUrl url, FilterPostIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.CommentsByPostIdUrl, string.Join(";", ids.Value));
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
