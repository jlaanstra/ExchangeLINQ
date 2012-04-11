using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Answers
{
	public interface IAnswersIdQuestionPostingUser
	{
		IdProp<InCall<FilterQuestionIds, int>> Question { get; }

		InCall<FilterIds, int> Id { get; }

		IdProp<InCall<FilterUserIds, int>> PostingUser { get; }
	}
}
