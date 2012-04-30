using System;

namespace ExchangeLINQ.Common.Types
{
	/// <summary>
	/// Generic class which can be used for operator overloading in LINQ queries containing ==.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="R"></typeparam>
	[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2224:OverrideEqualsOnOverloadingOperatorEquals")]
	public class Equal<T, R> where T : Filter<R>, new()
	{
		/// <summary>
		/// Implements the operator ==.
		/// </summary>
		/// <param name="arg">The arg.</param>
		/// <param name="returnValue">The return value.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates")]
		public static T operator ==(Equal<T, R> arg, R returnValue)
		{
			return new T() { Value = returnValue };
		}

		/// <summary>
		/// Implements the operator !=.
		/// </summary>
		/// <param name="arg">The arg.</param>
		/// <param name="returnValue">The return value.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates")]
		public static T operator !=(Equal<T, R> arg, R returnValue)
		{
			throw new NotImplementedException();
		}
	}
}
