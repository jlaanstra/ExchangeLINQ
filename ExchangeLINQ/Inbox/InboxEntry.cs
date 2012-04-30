using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Inbox
{
	public class InboxEntry : ProcessorState<InboxItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InboxEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal InboxEntry(ExchangeUrl url)
		{
			Contract.Requires(url != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.InboxUrl;
		}

		public InboxFilteredByUnread Where(Func<IInboxUnreadPageFilter, FilterUnread> f)
		{
			return new InboxFilteredByUnread(this.Url);
		}

		public FilteredByPage<InboxItem> Where(Func<IInboxUnreadPageFilter, FilterPage> f)
		{
			FilterPage filter = f(new InboxInterfacesImpl());
			return new FilteredByPage<InboxItem>(this.Url, filter);
		}

		public FilteredByFilter<InboxItem> Where(Func<IInboxUnreadPageFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InboxInterfacesImpl());
			return new FilteredByFilter<InboxItem>(this.Url, filter);
		}       
	}
}
