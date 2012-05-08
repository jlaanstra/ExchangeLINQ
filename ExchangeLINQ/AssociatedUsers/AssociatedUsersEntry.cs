using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AssociatedUsers
{
	public class AssociatedUsersEntry : State
	{
		/// <summary>
		/// Implements the Where query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AssociatedUsersFilteredByUserId Where(Func<IAssociatedUsersUserPage, FilterUserIds> f)
		{
			FilterUserIds ids = f(new AssociatedUsersInterfacesImpl());
			this.Url.QueryUrl = string.Format(UrlConstants.AssociatedUsersByIdUrl, string.Join(";",ids.Value));
			return new AssociatedUsersFilteredByUserId() { Url = this.Url };
		}

		/// <summary>
		/// Implements the Where query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AssociatedUsersFilteredByMe Where(Func<IAssociatedUsersUserPage, FilterMe> f)
		{
			this.Url.QueryUrl = UrlConstants.AssociatedMeUrl;
			return new AssociatedUsersFilteredByMe() { Url = this.Url };
		}

		public FilteredByPage<AccessToken> Where(Func<IAssociatedUsersUserPage, FilterPage> f)
		{
			FilterPage filter = f(new AssociatedUsersInterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
