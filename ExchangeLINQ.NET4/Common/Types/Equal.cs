using System;

namespace ExchangeLINQ.Common.Types
{
	/// <summary>
	/// Generic class which can be used for operator overloading in LINQ queries containing ==.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="R"></typeparam>
	public class Equal<T, R> where T : Filter<R>, new()
	{
		/// <summary>
		/// Implements the operator ==.
		/// </summary>
		/// <param name="errorId">The error id.</param>
		/// <param name="id">The id.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static T operator ==(Equal<T, R> arg, R returnValue)
		{
			return new T() { Value = returnValue };
		}

		/// <summary>
		/// Implements the operator !=.
		/// </summary>
		/// <param name="errorId">The error id.</param>
		/// <param name="id">The id.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static T operator !=(Equal<T, R> arg, R returnValue)
		{
			throw new NotImplementedException();
		}
	}
}
