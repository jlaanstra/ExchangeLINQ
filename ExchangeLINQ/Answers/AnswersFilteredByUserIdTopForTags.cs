using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using ExchangeLINQ.Complex;
using System;

namespace ExchangeLINQ.Answers
{
	public class AnswersFilteredByUserIdTopForTags : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AnswersFilteredByUserIdTopForTags"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		/// <param name="tags">The tags.</param>
		internal AnswersFilteredByUserIdTopForTags(ExchangeUrl url, FilterUserIds ids, FilterTags tags)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.TopAnswersByTagByUserIdUrl, string.Join(";", ids.Value), string.Join(";", tags.Value));
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
