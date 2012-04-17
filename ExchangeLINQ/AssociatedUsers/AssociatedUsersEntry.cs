using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Models;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.AssociatedUsers
{
	public class AssociatedUsersEntry : State
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssociatedUsersEntry"/> class.
		/// </summary>
		/// <param name="oAuth">The o auth.</param>
		internal AssociatedUsersEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.AssociatedMeUrl;
		}

		/// <summary>
		/// Implements the Where query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AssociatedUsersFilteredByUserId Where(Func<IdProp<InProp<FilterUserIds,int>>, FilterUserIds> f)
		{
			return new AssociatedUsersFilteredByUserId(this.Url, f(new IdProp<InProp<FilterUserIds,int>>()));
		}

		/// <summary>
		/// Implements the Where query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AssociatedUsersFilteredByMe Where(Func<IdProp<InProp<FilterUserIds, int>>, FilterMe> f)
		{
			return new AssociatedUsersFilteredByMe(this.Url);
		}

		public FilteredByPage<AccessToken> Where(Func<IPage, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
