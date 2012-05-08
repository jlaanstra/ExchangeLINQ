using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Answers
{
	public class AnswersEntry : ProcessorState<Answer>
	{
		/// <summary>
		/// Implements the Select query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredById Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterIds> f)
		{
			FilterIds ids = f(new AnswersInterfacesImpl());
			this.Url.QueryUrl = string.Format(UrlConstants.AnswersByIdUrl, string.Join(";", ids.Value));
			return new AnswersFilteredById() { Url = this.Url };
		}

		/// <summary>
		/// Wheres the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredByQuestionId Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterQuestionIds> f)
		{
			FilterQuestionIds ids = f(new AnswersInterfacesImpl());
			this.Url.QueryUrl = string.Format(UrlConstants.AnswersByQuestionIdUrl, string.Join(";", ids.Value));
			return new AnswersFilteredByQuestionId() { Url = this.Url };
		}

		/// <summary>
		/// Wheres the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredByUserId Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterUserIds> f)
		{
			FilterUserIds ids = f(new AnswersInterfacesImpl());
			this.Url.QueryUrl = string.Format(UrlConstants.AnswersByUserIdUrl, string.Join(";", ids.Value));
			return new AnswersFilteredByUserId() { Url = this.Url, Ids = ids };
		}

		/// <summary>
		/// Wheres the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredByMe Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterMe> f)
		{
			FilterMe me = f(new AnswersInterfacesImpl());
			this.Url.QueryUrl = UrlConstants.AnswersByMeUrl;
			return new AnswersFilteredByMe() { Url = this.Url };
		}

		#region Complex

		public FilteredByPage<Answer> Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new AnswersInterfacesImpl());
			return new FilteredByPage<Answer>(this.Url, filter);
		}

		public FilteredByFromDate<Answer> Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new AnswersInterfacesImpl());
			return new FilteredByFromDate<Answer>(this.Url, filter);
		}

		public FilteredByFilter<Answer> Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new AnswersInterfacesImpl());
			return new FilteredByFilter<Answer>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<Answer> OrderBy(Func<IOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new InterfacesImpl());
			return new OrderBy<Answer>(this.Url, filter);
		}

		public OrderByDescending<Answer> OrderByDescending(Func<IOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new InterfacesImpl());
			return new OrderByDescending<Answer>(this.Url, filter);
		}

		#endregion
	}
}
