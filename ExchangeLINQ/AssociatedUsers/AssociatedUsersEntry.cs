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
		public AssociatedUsersFilteredByUserId Where(Func<IAssociatedUsersUserPage, FilterUserIds> f)
		{
			return new AssociatedUsersFilteredByUserId(this.Url, f(new AssociatedUsersInterfacesImpl()));
		}

		/// <summary>
		/// Implements the Where query pattern.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public AssociatedUsersFilteredByMe Where(Func<IAssociatedUsersUserPage, FilterMe> f)
		{
			return new AssociatedUsersFilteredByMe(this.Url);
		}

		public FilteredByPage<AccessToken> Where(Func<IAssociatedUsersUserPage, FilterPage> f)
		{
			FilterPage filter = f(new AssociatedUsersInterfacesImpl());
			return new FilteredByPage<AccessToken>(this.Url, filter);
		}
	}
}
