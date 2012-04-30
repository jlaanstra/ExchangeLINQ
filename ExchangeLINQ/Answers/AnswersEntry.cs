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
		/// Initializes a new instance of the <see cref="AnswersEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal AnswersEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.AnswersUrl;
		}

		/// <summary>
		/// Implements the Select query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredById Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterIds> f)
		{
			return new AnswersFilteredById(this.Url, f(new AnswersInterfacesImpl()));
		}

		/// <summary>
		/// Wheres the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredByQuestionId Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterQuestionIds> f)
		{
			return new AnswersFilteredByQuestionId(this.Url, f(new AnswersInterfacesImpl()));
		}

		/// <summary>
		/// Wheres the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AnswersFilteredByUserId Where(Func<IAnswersIdQuestionPostingUserPageFromDateFilter, FilterUserIds> f)
		{
			return new AnswersFilteredByUserId(this.Url, f(new AnswersInterfacesImpl()));
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
