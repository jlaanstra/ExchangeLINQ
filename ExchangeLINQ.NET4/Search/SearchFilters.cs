using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Search
{
	public class FilterTags : Filter<IEnumerable<string>> { }

	public class FilterTitle : Filter<string> { }

	public class FilterOrderBy : Filter<string> { }
}
