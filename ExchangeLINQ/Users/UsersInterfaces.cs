using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Users
{
	public interface IUsersNameIdMeIsModeratorPageFromDateFilter : IPageFromDateFilter
	{
		ContainsProp<FilterName, string> Name { get; }

		InProp<FilterIds, int> Id { get; }

		FilterMe Me { get; }

		FilterIsModerator IsModerator { get; }
	}

	public interface IUsersIsElectedPageFromDateFilter : IPageFromDateFilter
	{
		FilterIsElected IsElected { get; }
	}

	public interface IOrderByReputationCreationNameModified
	{
		FilterOrderBy Creation { get; }
		FilterOrderBy Reputation { get; }
		FilterOrderBy Name { get; }
		FilterOrderBy Modified { get; }
	}
}
