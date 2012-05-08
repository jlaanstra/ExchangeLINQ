using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using ExchangeLINQ.Complex;
using System;

namespace ExchangeLINQ.Sites
{
	public class SitesEntry : ProcessorState<Site>
	{
		#region Complex

		public FilteredByPage<Site> Where(Func<IPageFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<Site>(this.Url, filter);
		}

		public FilteredByFilter<Site> Where(Func<IPageFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<Site>(this.Url, filter);
		}

		#endregion
	}
}
