using ExchangeLINQ.Common.Types;
using System.Collections.Generic;

namespace ExchangeLINQ.Common
{
	public class FilterIds : Filter<IEnumerable<int>> { }

	public class FilterUserIds : Filter<IEnumerable<int>> { }

	public class FilterMe { }

	public class FilterOrderBy : Filter<string> { }
}
