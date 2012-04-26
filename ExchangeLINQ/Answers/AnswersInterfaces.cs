using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Answers
{
	public interface IAnswersIdQuestionPostingUserPageFromDateFilter : IPageFromDateFilter
	{
		IdProp<InProp<FilterQuestionIds, int>> Question { get; }

		InProp<FilterIds, int> Id { get; }

		UserProp<IdProp<InProp<FilterUserIds, int>>> PostingUser { get; }
	}

	public interface IAnswersIsTopAnswerForTagPageFromDateFilter : IPageFromDateFilter
	{
		InProp<FilterTags, string> IsTopAnswerForTag { get; }
	}
}
