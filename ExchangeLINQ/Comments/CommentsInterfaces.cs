using System.Collections.Generic;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Comments
{
	public interface ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter : IPageFromDateFilter
	{
		InProp<FilterIds,int> Id { get; }

		IdProp<InProp<FilterPostIds, int>> Post { get; }

		IdProp<InProp<FilterQuestionIds, int>> Question { get; }

		IdProp<InProp<FilterAnswerIds, int>> Answer { get; }

		UserProp<InProp<FilterUserIds, int>> User { get; }
	}
	
	public interface ICommentsReplyToUserPageFromDateFilter : IPageFromDateFilter
	{
		IdProp<FilterId> ReplyToUser { get; }
	}
}
