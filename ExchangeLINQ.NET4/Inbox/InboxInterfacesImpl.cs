using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Inbox
{
	public class InboxInterfacesImpl : IInboxUnreadPageFilter
	{
		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }

		public Equal<FilterFilter, string> Filter { get { return new Equal<FilterFilter, string>(); } }

		public FilterUnread IsUnread { get { return new FilterUnread(); } }
	}
}
