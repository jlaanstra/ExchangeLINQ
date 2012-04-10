using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Complex
{
	public class FilteredByFromDateToDate<T> : ProcessorState<T>
	{
		internal FilteredByFromDateToDate(ExchangeUrl url, FilterToDate toDate)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			this.Url = url;
			this.Url.AddQueryOption("todate", toDate.Value.ToUnixTimeStamp().ToString());
		}

		public FilteredByPage<T> Where(Func<IPage, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<T>(this.Url, filter);
		}

		public FilteredByFilter<T> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<T>(this.Url, filter);
		}
	}
}
