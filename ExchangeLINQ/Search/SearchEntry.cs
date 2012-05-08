using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Search
{
	public class SearchEntry : State
	{
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
