using System;
using System.Net;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Comments
{
	public class FilterPostIds : FilterIds {}

	public class FilterQuestionIds : FilterIds { }

	public class FilterAnswerIds : FilterIds { }

	public class FilterUserIds : FilterIds { }

	public class FilterToId : Filter<int> { }

	public class FilterId : Filter<int> { }
}
