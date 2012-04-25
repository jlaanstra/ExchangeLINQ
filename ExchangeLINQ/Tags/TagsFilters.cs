using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Tags
{
	public class FilterModeratorOnly { }

	public class FilterRequired { }

	public class FilterNames : Filter<IEnumerable<string>> { }

	public class FilterNameContains : Filter<string> { }
}
