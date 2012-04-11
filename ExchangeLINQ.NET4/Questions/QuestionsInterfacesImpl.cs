using System;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Questions
{
	internal class QuestionsInterfacesImpl : IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter,
		IQuestionTagsPageFromDateFilter, IQuestionsOrderByActivityCreationScoreHotWeekMonth, IQuestionsOrderByActivityCreationScore, 
		IQuestionsOrderByActivityCreationScoreRank
	{
		public FilterOrderBy Activity { get { return new FilterOrderBy() { Value = "activity" }; } }

		public FilterOrderBy Creation { get { return new FilterOrderBy() { Value = "creation" }; } }

		public FilterOrderBy Score { get { return new FilterOrderBy() { Value = "votes" }; } }

		public FilterOrderBy Hot { get { return new FilterOrderBy() { Value = "hot" }; } }

		public FilterOrderBy Week { get { return new FilterOrderBy() { Value = "week" }; } }

		public FilterOrderBy Month { get { return new FilterOrderBy() { Value = "month" }; } }

		public FilterOrderBy Rank { get { return new FilterOrderBy() { Value = "rank" }; } }

		#region IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDate

		public InCall<FilterIds, int> Id { get { return new InCall<FilterIds, int>(); } }

		public InCall<FilterTags, string> Tags { get { return new InCall<FilterTags,string>(); } }

		public InCall<FilterIsRelatedTo, int> IsRelatedTo { get { return new InCall<FilterIsRelatedTo,int>(); } }

		public IdProp<Equal<FilterLinksToId, int>> LinksTo { get { return new IdProp<Equal<FilterLinksToId, int>>(); } }

		public IdProp<Equal<FilterPostingUserId, int>> PostingUser { get { return new IdProp<Equal<FilterPostingUserId, int>>(); } }

		public FilterFeatured IsFeatured { get { return new FilterFeatured(); } }

		public FilterUnanswered IsUnanswered { get { return new FilterUnanswered(); } }

		public FilterNoAnswers HasNoAnswers { get { return new FilterNoAnswers(); } }

		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }

		public Equal<FilterFromDate, DateTime> FromDate { get { return new Equal<FilterFromDate, DateTime>(); } }

		public Equal<FilterFilter, string> Filter { get { return new Equal<FilterFilter, string>(); } }

		#endregion
	}
}
