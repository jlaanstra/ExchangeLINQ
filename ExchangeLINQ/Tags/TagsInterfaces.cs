using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Tags
{
	public interface ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter : IPageFromDateFilter
	{
		FilterModeratorOnly ModeratorOnly { get; }

		FilterRequired Required { get; }

		ContainsIn Name { get; }

		UserProp<InProp<FilterUserIds, int>> User { get; }
	}

	public interface ITagsOrderByNameActivityPopular
	{
		FilterOrderBy Name { get; }
		FilterOrderBy Activity { get; }
		FilterOrderBy Popular { get; }
	}
}
