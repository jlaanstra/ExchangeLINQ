using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeLINQ.Tags
{
	public class ContainsIn
	{
		/// <summary>
		/// Ins the specified ids.
		/// </summary>
		/// <param name="ids">The ids.</param>
		/// <returns></returns>
		public FilterNames In(params string[] ids)
		{
			return this.In(ids.AsEnumerable<string>());
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="ids">The ids.</param>
		/// <returns></returns>
		public FilterNames In(IEnumerable<string> ids)
		{
			return new FilterNames() { Value = ids };
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="arg">The arg.</param>
		/// <returns></returns>
		public FilterNameContains Contains(string arg)
		{
			return new FilterNameContains() { Value = arg };
		}
	}
}
