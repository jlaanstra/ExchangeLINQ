using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Search
{
	public class SearchFilteredByInTitle : ProcessorState<Question>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SearchFilteredByInTitle"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="title">The title.</param>
		internal SearchFilteredByInTitle(ExchangeUrl url, FilterTitle title)
		{
			Contract.Requires(url == null);
			Contract.Requires(title == null);

			this.Url = url;
			this.Url.AddQueryOption("intitle", title.Value);
		}

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

		#region OrderBy

		public SearchOrderBy OrderBy(Func<ISearchOrderByActivityCreationScoreRelevance, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new SearchInterfacesImpl());
			return new SearchOrderBy(this.Url, filter);
		}

		public SearchOrderByDescending OrderByDescending(Func<ISearchOrderByActivityCreationScoreRelevance, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new SearchInterfacesImpl());
			return new SearchOrderByDescending(this.Url, filter);
		}

		#endregion
	}
}
