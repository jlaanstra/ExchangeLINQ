using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Complex
{
	public class FilterPage : Filter<int> { }

	public class FilterPageSize : Filter<int> { }

	public class FilterFromDate : Filter<DateTime> { }

	public class FilterToDate : Filter<DateTime> { }

	public class FilterFilter : Filter<string> { }
}
