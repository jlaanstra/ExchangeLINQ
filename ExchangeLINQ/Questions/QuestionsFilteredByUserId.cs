using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredByUserId : ProcessorState<Answer>
	{
		private FilterUserIds ids;

		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsFilteredByUserId"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal QuestionsFilteredByUserId(ExchangeUrl url, FilterUserIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.QuestionsByUserIdUrl, String.Join(";", ids.Value));

			this.ids = ids;
		}

		public QuestionsFilteredByUserIdFavorites Where(Func<IQuestionIsFavoritePageFromDateFilter, FilterFavorite> f)
		{
			return new QuestionsFilteredByUserIdFavorites(this.Url, this.ids, f(new QuestionsInterfacesImpl()));
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
