using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using System;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Answers
{
	public class AnswersFilteredByMe : ProcessorState<Answer>
	{
		private FilterMe me;

		/// <summary>
		/// Initializes a new instance of the <see cref="AnswersFilteredByMe"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="me">Me.</param>
		internal AnswersFilteredByMe(ExchangeUrl url, FilterMe me)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.AnswersByMeUrl;

			this.me = me;
		}

		public AnswersFilteredByMeTopForTags Where(Func<IAnswersIsTopAnswerForTagPageFromDateFilter, FilterTags> f)
		{
			return new AnswersFilteredByMeTopForTags(this.Url, this.me, f(new AnswersInterfacesImpl()));
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
