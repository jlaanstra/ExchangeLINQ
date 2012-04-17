using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Complex
{
	public class FilteredByFromDate<T> : State
	{
		internal FilteredByFromDate(ExchangeUrl url, FilterFromDate fromDate)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			this.Url = url;
			this.Url.AddQueryOption("fromdate", fromDate.Value.ToUnixTimeStamp().ToString());
		}

		public FilteredByFromDateToDate<T> Where(Func<IToDateFilter, FilterToDate> f)
		{
			FilterToDate filter = f(new InterfacesImpl());
			return new FilteredByFromDateToDate<T>(this.Url, filter);
		}
	}
}
