using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using System;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Answers
{
	public class AnswersFilteredByMe : ProcessorState<Answer>
	{
		public AnswersFilteredByMeTopForTags Where(Func<IAnswersIsTopAnswerForTagPageFromDateFilter, FilterTags> f)
		{
			FilterTags tags = f(new AnswersInterfacesImpl());
			this.Url.QueryUrl = string.Format(UrlConstants.TopAnswersByTagByMeUrl, string.Join(";", tags.Value));
			return new AnswersFilteredByMeTopForTags() { Url = this.Url };
		}

		#region Complex

		public FilteredByPage<Answer> Where(Func<IAnswersIsTopAnswerForTagPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new AnswersInterfacesImpl());
			return new FilteredByPage<Answer>(this.Url, filter);
		}

		public FilteredByFromDate<Answer> Where(Func<IAnswersIsTopAnswerForTagPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new AnswersInterfacesImpl());
			return new FilteredByFromDate<Answer>(this.Url, filter);
		}

		public FilteredByFilter<Answer> Where(Func<IAnswersIsTopAnswerForTagPageFromDateFilter, FilterFilter> f)
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
