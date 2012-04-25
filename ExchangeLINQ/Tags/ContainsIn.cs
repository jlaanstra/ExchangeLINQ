using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeLINQ.Tags
{
	public class ContainsIn
	{
		/// <summary>
		/// Method added to hook into the c# params syntax.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		public FilterNames In(params string[] ids)
		{
			return this.In(ids.AsEnumerable<string>());
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		public FilterNames In(IEnumerable<string> ids)
		{
			return new FilterNames() { Value = ids };
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		public FilterNameContains Contains(string arg)
		{
			return new FilterNameContains() { Value = arg };
		}
	}
}
