using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AssociatedUsers
{
	public class AssociatedUsersEntry : ProcessorState<NetworkUser>
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
		public AssociatedUsersFilteredById Where(Func<IdProp<InCall<FilterUserIds,int>>, FilterUserIds> f)
		{
			return new AssociatedUsersFilteredById(this.Url, f(new IdProp<InCall<FilterUserIds,int>>()));
		}
	}
}
