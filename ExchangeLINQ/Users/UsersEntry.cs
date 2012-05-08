using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common;
using System;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Users
{
	public class UsersEntry : ProcessorState<User>
	{
		public UsersFilteredByName Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterName> f)
		{
			return new UsersFilteredByName(this.Url, f(new UsersInterfacesImpl()));
		}

		public UsersFilteredById Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterIds> f)
		{
			return new UsersFilteredById(this.Url, f(new UsersInterfacesImpl()));
		}

		public UsersFilteredByMe Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterMe> f)
		{
			return new UsersFilteredByMe(this.Url, f(new UsersInterfacesImpl()));
		}

		public UsersFilteredByIsModerator Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterIsModerator> f)
		{
			return new UsersFilteredByIsModerator(this.Url, f(new UsersInterfacesImpl()));
		}

		#region Complex

		public FilteredByPage<User> Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new UsersInterfacesImpl());
			return new FilteredByPage<User>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new UsersInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<User> Where(Func<IUsersNameIdMeIsModeratorPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new UsersInterfacesImpl());
			return new FilteredByFilter<User>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<User> OrderBy(Func<IOrderByReputationCreationNameModified, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new UsersInterfacesImpl());
			return new OrderBy<User>(this.Url, filter);
		}

		public OrderByDescending<User> OrderByDescending(Func<IOrderByReputationCreationNameModified, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new UsersInterfacesImpl());
			return new OrderByDescending<User>(this.Url, filter);
		}

		#endregion
	}
}
