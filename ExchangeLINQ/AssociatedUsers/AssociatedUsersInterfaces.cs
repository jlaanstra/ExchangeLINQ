using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.AssociatedUsers
{
	public interface IAssociatedUsersUserPage : IPage
	{
		UserProp<IdProp<FilterIds>> User { get; }
	}
}
