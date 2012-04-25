using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Search
{
	public class SearchInterfacesImpl : ISearchTaggedInTitle, ISearchOrderByActivityCreationScoreRelevance
	{
		public InProp<FilterTags, string> Tags { get { return new InProp<FilterTags, string>(); } }

		public ContainsProp<FilterTitle, string> Title { get { return new ContainsProp<FilterTitle, string>(); } }

		#region ISearchOrderByActivityCreationScoreRelevance
		
		public FilterOrderBy Activity { get { return new FilterOrderBy() { Value = "activity" }; } }

		public FilterOrderBy Creation { get { return new FilterOrderBy() { Value = "creation" }; } }

		public FilterOrderBy Score { get { return new FilterOrderBy() { Value = "votes" }; } }

		public FilterOrderBy Relevance { get { return new FilterOrderBy(){ Value = "relevance"};} }

		#endregion
	}
}
