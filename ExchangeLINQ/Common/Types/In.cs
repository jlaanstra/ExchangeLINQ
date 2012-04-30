using System.Collections.Generic;
using System.Linq;

namespace ExchangeLINQ.Common.Types
{
	/// <summary>
	/// Generic class which can be used for In call chains in Linq queries.
	/// </summary>
	/// <typeparam name="Filter"></typeparam>
	/// <typeparam name="ClrType"></typeparam>
	public class InProp<Filter, ClrType> where Filter : Filter<IEnumerable<ClrType>>, new()
	{
		/// <summary>
		/// Method added to hook into the c# params syntax.
		/// </summary>
		/// <param name="ids">The ids.</param>
		/// <returns></returns>
		public Filter In(params ClrType[] ids)
		{
			return this.In(ids.AsEnumerable<ClrType>());
		}

		/// <summary>
		/// Ins the specified ids.
		/// </summary>
		/// <param name="ids">The ids.</param>
		/// <returns></returns>
		public Filter In(IEnumerable<ClrType> ids)
		{
			return new Filter() { Value = ids };
		}
	}
}
