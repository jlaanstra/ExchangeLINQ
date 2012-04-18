using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.AssociatedUsers
{
	public interface IAssociatedUsersUserPage : IPage
	{
		UserProp<IdProp<FilterIds>> User { get; }
	}
}
