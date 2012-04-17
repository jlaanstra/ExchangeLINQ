using System;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.AssociatedUsers
{
	public class AssociatedUsersInterfacesImpl : IAssociatedUsersUserPage
	{
		public UserProp<IdProp<FilterIds>> User { get { return new UserProp<IdProp<FilterIds>>(); } }

		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }
	}
}
