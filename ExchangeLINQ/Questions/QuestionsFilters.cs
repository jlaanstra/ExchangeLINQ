using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Questions
{
	public class FilterTags : Filter<IEnumerable<string>> { }

	public class FilterIsRelatedTo : Filter<IEnumerable<int>> { }

	public class FilterUserId : Filter<IEnumerable<int>> { }

	public class FilterLinksToId : Filter<int> { }

	public class FilterPostingUserId : Filter<int> { }

	public class FilterFeatured { }

	public class FilterUnanswered { }

	public class FilterNoAnswers { }
}
