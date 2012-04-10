using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeLINQ.Badges
{
	internal class BadgesInterfacesImpl : IBadgesIn
	{
		/// <summary>
		/// Method added to hook into the c# params syntax.
		/// </summary>
		/// <param name="ids">The tokens.</param>
		/// <returns></returns>
		public IEnumerable<int> In(params int[] ids)
		{
			return this.In(ids.AsEnumerable<int>());
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="ids">The tokens.</param>
		/// <returns></returns>
		public IEnumerable<int> In(IEnumerable<int> ids)
		{
			//limit to 20 according to http://api.stackexchange.com/docs/read-access-tokens
			if (ids.Count() > 100)
			{
				throw new InvalidOperationException("You can only specify up to 100 ids.");
			}
			return ids;
		}
	}
}
