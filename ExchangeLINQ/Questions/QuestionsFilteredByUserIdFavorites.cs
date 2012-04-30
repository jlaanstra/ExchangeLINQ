using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredByUserIdFavorites : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsFilteredByUserIdFavorites"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		/// <param name="favorite">The favorite.</param>
		internal QuestionsFilteredByUserIdFavorites(ExchangeUrl url, FilterUserIds ids, FilterFavorite favorite)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.FavoritesByUserIdUrl, String.Join(";", ids.Value));
		}

		#region Complex
		
		public FilteredByPage<Question> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new InterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
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
