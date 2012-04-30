using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeLINQ.Common.Types
{
	/// <summary>
	/// Generic class which can be used for In call chains in Linq queries.
	/// </summary>
	/// <typeparam name="Filter"></typeparam>
	/// <typeparam name="ClrType"></typeparam>
	public class ContainsProp<Filter, ClrType> where Filter : Filter<ClrType>, new()
	{
		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="arg">The arg.</param>
		/// <returns></returns>
		public Filter Contains(ClrType arg)
		{
			return new Filter() { Value = arg };
		}
	}
}
