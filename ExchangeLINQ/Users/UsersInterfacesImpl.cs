using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Users
{
	public class UsersInterfacesImpl : IUsersNameIdMeIsModeratorPageFromDateFilter, IUsersIsElectedPageFromDateFilter , IOrderByReputationCreationNameModified
	{
		public ContainsProp<FilterName, string> Name { get { return new ContainsProp<FilterName, string>(); } }

		public InProp<FilterIds, int> Id { get { return new InProp<FilterIds, int>(); } }

		public FilterMe Me { get { return new FilterMe(); } }

		public FilterIsModerator IsModerator { get { return new FilterIsModerator(); } }

		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }

		public Equal<FilterFromDate, DateTime> FromDate { get { return new Equal<FilterFromDate, DateTime>(); } }

		public Equal<FilterFilter, string> Filter { get { return new Equal<FilterFilter, string>(); } }

		public FilterOrderBy Creation { get { return new FilterOrderBy() { Value = "creation" }; } }

		public FilterOrderBy Reputation { get { return new FilterOrderBy() { Value = "reputation" }; } }

		FilterOrderBy IOrderByReputationCreationNameModified.Name { get { return new FilterOrderBy() { Value = "name" }; } }

		public FilterOrderBy Modified { get { return new FilterOrderBy() { Value = "modified" }; } }

		public FilterIsElected IsElected { get { return new FilterIsElected(); } }
	}
}
