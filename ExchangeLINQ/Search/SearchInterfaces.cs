using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Search
{
	public interface ISearchTaggedInTitle
	{
		InProp<FilterTags, string> Tags { get; }

		Equal<FilterTitle, string> Title { get; }
	}

	public interface ISearchOrderByActivityCreationScoreRelevance
	{
		FilterOrderBy Activity { get; }
		FilterOrderBy Creation { get; }
		FilterOrderBy Score { get; }
		FilterOrderBy Relevance { get; }
	}
}
