using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	public class BadgesFilteredByRecent : ProcessorState<Badge>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BadgesFilteredByRecent"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal BadgesFilteredByRecent(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.BadgesRecipientsUrl;
		}

		#region Complex

		public FilteredByPage<Answer> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<Answer>(this.Url, filter);
		}

		public FilteredByFromDate<Answer> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new InterfacesImpl());
			return new FilteredByFromDate<Answer>(this.Url, filter);
		}

		public FilteredByFilter<Answer> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<Answer>(this.Url, filter);
		}

		#endregion
	}
}
