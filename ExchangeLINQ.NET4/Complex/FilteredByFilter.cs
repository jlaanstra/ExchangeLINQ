using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;

namespace ExchangeLINQ.Complex
{
	public class FilteredByFilter<T> : ProcessorState<T>
	{
		internal FilteredByFilter(ExchangeUrl url, FilterFilter filter)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			this.Url = url;
			this.Url.AddQueryOption("filter", filter.Value);
		}
	}
}
