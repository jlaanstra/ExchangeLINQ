using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Users
{
	public class UsersFilteredByName : ProcessorState<User>
	{
		internal UsersFilteredByName(ExchangeUrl url, FilterName name)
		{
			this.Url = url;
			this.Url.AddQueryOption("inname", name.Value);
		}

		#region Complex

		public FilteredByPage<User> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new UsersInterfacesImpl());
			return new FilteredByPage<User>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new UsersInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<User> Where(Func<IPageFromDateFilter, FilterFilter> f)
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
