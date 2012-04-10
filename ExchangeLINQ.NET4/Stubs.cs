using System;

namespace ExchangeLINQ
{
	internal static class Stubs
	{
		public static readonly Action Nop = delegate { };
		public static readonly Action<Exception> Throw = delegate(Exception ex)	{ throw ex;	};
	}

	internal static class Stubs<T>
	{
		public static readonly Action<T> Ignore = delegate(T _) { };
	}
}
