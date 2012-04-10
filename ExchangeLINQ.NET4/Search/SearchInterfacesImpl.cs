using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Search
{
	public class SearchInterfacesImpl : ISearchTaggedInTitle, ISearchOrderByActivityCreationScoreRelevance
	{
		public InCall<FilterTags, string> Tags { get { return new InCall<FilterTags, string>(); } }

		public Equal<FilterTitle, string> Title { get { return new Equal<FilterTitle, string>(); } }

		#region ISearchOrderByActivityCreationScoreRelevance
		
		public FilterOrderBy Activity { get { return new FilterOrderBy() { Value = "activity" }; } }

		public FilterOrderBy Creation { get { return new FilterOrderBy() { Value = "creation" }; } }

		public FilterOrderBy Score { get { return new FilterOrderBy() { Value = "votes" }; } }

		public FilterOrderBy Relevance { get { return new FilterOrderBy(){ Value = "relevance"};} }

		#endregion
	}
}
