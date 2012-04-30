using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Inbox
{
	public class InboxFilteredByUnread : ProcessorState<InboxItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InboxFilteredByUnread"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal InboxFilteredByUnread(ExchangeUrl url)
		{
			Contract.Requires(url != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.InboxUnreadUrl;
		}

		public FilteredByPage<InboxItem> Where(Func<IPageFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<InboxItem>(this.Url, filter);
		}

		public FilteredByFilter<InboxItem> Where(Func<IPageFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<InboxItem>(this.Url, filter);
		}
	}
}
