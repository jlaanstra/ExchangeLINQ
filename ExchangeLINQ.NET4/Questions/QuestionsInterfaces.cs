using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Questions
{	
	public interface IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter : IPageFromDateFilter
	{
		InCall<FilterIds, int> Id { get; }

		InCall<FilterTags, string> Tags { get; }

		InCall<FilterIsRelatedTo, int> IsRelatedTo { get; }

		IdProp<Equal<FilterLinksToId, int>> LinksTo { get; }

		IdProp<Equal<FilterPostingUserId, int>> PostingUser { get; }

		FilterFeatured IsFeatured { get; }

		FilterUnanswered IsUnanswered { get; }

		FilterNoAnswers HasNoAnswers { get; }
	}

	public interface IQuestionTagsPageFromDateFilter : IPageFromDateFilter
	{
		InCall<FilterTags, string> Tags { get; }
	}

	public interface IQuestionsOrderByActivityCreationScoreHotWeekMonth : IQuestionsOrderByActivityCreationScore
	{
		FilterOrderBy Hot { get; }
		FilterOrderBy Week { get; }
		FilterOrderBy Month { get; }
	}

	public interface IQuestionsOrderByActivityCreationScoreRank : IQuestionsOrderByActivityCreationScore
	{
		FilterOrderBy Rank { get; }
	}

	public interface IQuestionsOrderByActivityCreationScore
	{
		FilterOrderBy Activity { get; }
		FilterOrderBy Creation { get; }
		FilterOrderBy Score { get; }
	}
}
