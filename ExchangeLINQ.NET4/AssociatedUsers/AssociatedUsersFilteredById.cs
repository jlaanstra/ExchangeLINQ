using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.AssociatedUsers
{
	public class AssociatedUsersFilteredById : ProcessorState<NetworkUser>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AssociatedUsersFilteredById"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		/// <param name="ids">The ids.</param>
		internal AssociatedUsersFilteredById(ExchangeUrl url, FilterUserIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.AssociatedUsersByIdUrl, ids.Value);
		}
	}
}
