using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredByMe : ProcessorState<Question>
	{
		private FilterMe me;

		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsFilteredByMe"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="me">Me.</param>
		internal QuestionsFilteredByMe(ExchangeUrl url, FilterMe me)
		{
			Contract.Requires(url != null);
			Contract.Requires(me != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.QuestionsByMeUrl;

			this.me = me;
		}

		public QuestionsFilteredByMeFavorites Where(Func<IQuestionIsFavoritePageFromDateFilter, FilterFavorite> f)
		{
			return new QuestionsFilteredByMeFavorites(this.Url, this.me, f(new QuestionsInterfacesImpl()));
		}

		#region Complex

		public FilteredByPage<Question> Where(Func<IQuestionIsFavoritePageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new QuestionsInterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IQuestionIsFavoritePageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IQuestionIsFavoritePageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFilter<Question>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<Question> OrderBy(Func<IOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new OrderBy<Question>(this.Url, filter);
		}

		public OrderByDescending<Question> OrderByDescending(Func<IOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new OrderByDescending<Question>(this.Url, filter);
		}

		#endregion
	}
}
