using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Search
{
	public class SearchFilteredByTagged : ProcessorState<Question>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal SearchFilteredByTagged(ExchangeUrl url, FilterTags tags)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			if (tags == null)
			{
				throw new ArgumentNullException("tags");
			}
			this.Url = url;
			this.Url.AddQueryOption("tagged", String.Join(";",tags.Value));
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
