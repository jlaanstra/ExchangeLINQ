using System.Collections.Generic;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Common
{
	public class FilterIds : Filter<IEnumerable<int>> { }

	public class FilterUserIds : Filter<IEnumerable<int>> { }

	public class FilterMe { }

	public class FilterOrderBy : Filter<string> { }

	public class FilterTags : Filter<IEnumerable<string>> { }
}
