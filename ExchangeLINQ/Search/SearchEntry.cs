using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Search
{
	public class SearchEntry : State
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SearchEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal SearchEntry(ExchangeUrl url)
		{
			Contract.Requires(url != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.SearchUrl;
		}

		#region Questions

		public SearchFilteredByTagged Where(Func<ISearchTaggedInTitle, FilterTags> f)
		{
			FilterTags filter = f(new SearchInterfacesImpl());
			return new SearchFilteredByTagged(this.Url, filter);
		}

		public SearchFilteredByInTitle Where(Func<ISearchTaggedInTitle, FilterTitle> f)
		{
			FilterTitle filter = f(new SearchInterfacesImpl());
			return new SearchFilteredByInTitle(this.Url, filter);
		}

		#endregion
	}
}
