using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Complex
{
	public class FilteredByPagePageSize<T> : ProcessorState<T>
	{
		internal FilteredByPagePageSize(ExchangeUrl url, FilterPageSize pageSize)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			this.Url = url;
			this.Url.AddQueryOption("pageSize", pageSize.Value.ToString());
		}

		public FilteredByFilter<T> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<T>(this.Url, filter);
		}
	}
}
