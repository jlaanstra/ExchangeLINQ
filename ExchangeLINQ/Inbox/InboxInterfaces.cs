using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Inbox
{
    public interface IInboxUnreadPageFilter : IPageFilter
    {
        FilterUnread IsUnread { get; }
    }
}
