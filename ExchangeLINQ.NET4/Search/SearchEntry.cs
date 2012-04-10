using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Search
{
	public class SearchEntry : State
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		internal SearchEntry(ExchangeUrl url)
		{
			if(url == null)
			{
				throw new ArgumentNullException("url");
			}
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
