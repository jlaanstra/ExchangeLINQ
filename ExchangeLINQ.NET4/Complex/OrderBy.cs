using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Complex
{
	public class OrderBy<T> : ProcessorState<T>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OrderBy"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="orderby">The orderby.</param>
		internal OrderBy(ExchangeUrl url, FilterOrderBy orderby)
		{
			this.Url = url;
			this.Url.AddQueryOption("sort", orderby.Value);
			this.Url.AddQueryOption("order", "asc");
		}

		public FilteredByPage<T> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<T>(this.Url, filter);
		}

		public FilteredByFromDate<T> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new InterfacesImpl());
			return new FilteredByFromDate<T>(this.Url, filter);
		}

		public FilteredByFilter<T> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<T>(this.Url, filter);
		}
	}
}
