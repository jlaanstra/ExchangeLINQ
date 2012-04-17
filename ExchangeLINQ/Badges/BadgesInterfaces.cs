using System.Collections.Generic;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Badges
{
	public interface IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter : IPageFromDateFilter
	{
		Equal<FilterName, string> Name { get; }

		InProp<FilterIds, int> Id { get; }

		FilterNonTagBased NonTagBased { get; }

		FilterTagBased TagBased { get; }

		FilterRecent IsRecentlyAwarded { get; }
	}

	public interface IBadgesRecentlyAwardedPageFromDateFilter : IPageFromDateFilter
	{
		FilterRecent IsRecentlyAwarded { get; }
	}

	public interface IBadgesOrderByNameRank
	{
		FilterOrderBy Name { get; }
		FilterOrderBy Rank { get; }
	}

	public interface IBadgesOrderByNameRankType : IBadgesOrderByNameRank
	{
		FilterOrderBy Type { get; }
	}
}
