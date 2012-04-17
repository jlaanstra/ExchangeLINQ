using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Complex
{
	public class FilteredByPage<T> : State
	{
		internal FilteredByPage(ExchangeUrl url, FilterPage page)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			this.Url = url;
			this.Url.AddQueryOption("page", page.Value.ToString());
		}

		public FilteredByPagePageSize<T> Where(Func<IPageSizeFilter, FilterPageSize> f)
		{
			FilterPageSize filter = f(new InterfacesImpl());
			return new FilteredByPagePageSize<T>(this.Url, filter);
		}
	}
}
