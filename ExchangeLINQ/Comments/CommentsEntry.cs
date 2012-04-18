using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	internal class CommentsEntry : ProcessorState<Comment>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		public CommentsEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.CommentsUrl;
		}

		#region Where

		public CommentsFilteredById Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterIds> f)
		{
			return new CommentsFilteredById(this.Url, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByQuestionId Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterQuestionIds> f)
		{
			return new CommentsFilteredByQuestionId(this.Url, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByAnswerId Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterAnswerIds> f)
		{
			return new CommentsFilteredByAnswerId(this.Url, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByPostId Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterPostIds> f)
		{
			return new CommentsFilteredByPostId(this.Url, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByUserId Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterUserIds> f)
		{
			return new CommentsFilteredByUserId(this.Url, f(new CommentsInterfacesImpl()));
		}

		public CommentsFilteredByMe Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterMe> f)
		{
			return new CommentsFilteredByMe(this.Url);
		}

		#endregion

		#region Complex

		public FilteredByPage<Comment> Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterPage> f)
		{
			return new FilteredByPage<Comment>(this.Url, f(new CommentsInterfacesImpl()));
		}

		public FilteredByFromDate<Comment> Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterFromDate> f)
		{
			return new FilteredByFromDate<Comment>(this.Url, f(new CommentsInterfacesImpl()));
		}

		public FilteredByFilter<Comment> Where(Func<ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter, FilterFilter> f)
		{
			return new FilteredByFilter<Comment>(this.Url, f(new CommentsInterfacesImpl()));
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
