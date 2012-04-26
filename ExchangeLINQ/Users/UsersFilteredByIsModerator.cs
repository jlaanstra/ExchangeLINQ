using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Users
{
	public class UsersFilteredByIsModerator : ProcessorState<User>
	{
		private FilterIsModerator mod;

		internal UsersFilteredByIsModerator(ExchangeUrl url, FilterIsModerator mod)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.ModeratorsUrl;

			this.mod = mod;
		}

		public UsersFilteredByIsModeratorElected Where(Func<IUsersIsElectedPageFromDateFilter, FilterIsElected> f)
		{
			return new UsersFilteredByIsModeratorElected(this.Url, this.mod, f(new UsersInterfacesImpl()));
		}

		#region Complex

		public FilteredByPage<User> Where(Func<IUsersIsElectedPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new UsersInterfacesImpl());
			return new FilteredByPage<User>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IUsersIsElectedPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new UsersInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<User> Where(Func<IUsersIsElectedPageFromDateFilter, FilterFilter> f)
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
