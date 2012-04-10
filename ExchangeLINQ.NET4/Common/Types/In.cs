using System.Collections.Generic;
using System.Linq;

namespace ExchangeLINQ.Common.Types
{
	/// <summary>
	/// Generic class which can be used for In call chains in Linq queries.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="U"></typeparam>
	public class InCall<T, U> where T : Filter<IEnumerable<U>>, new()
	{
		/// <summary>
		/// Method added to hook into the c# params syntax.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		public T In(params U[] ids)
		{
			return this.In(ids.AsEnumerable<U>());
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		public T In(IEnumerable<U> ids)
		{
			return new T() { Value = ids };
		}
	}
}
