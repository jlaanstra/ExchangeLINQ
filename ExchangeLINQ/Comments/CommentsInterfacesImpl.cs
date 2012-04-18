using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Comments
{
	public class CommentsInterfacesImpl : ICommentsIdPostIdQuestionIdAnswerIdUserIdMePageFromDateFilter,
		ICommentsReplyToUserPageFromDateFilter
	{
		public InProp<FilterIds, int> Id { get { return new InProp<FilterIds, int>(); } }

		public IdProp<InProp<FilterPostIds, int>> Post { get { return new IdProp<InProp<FilterPostIds, int>>(); } }

		public IdProp<InProp<FilterQuestionIds, int>> Question { get { return new IdProp<InProp<FilterQuestionIds, int>>(); } }

		public IdProp<InProp<FilterAnswerIds, int>> Answer { get { return new IdProp<InProp<FilterAnswerIds, int>>(); } }

		public UserProp<InProp<FilterUserIds, int>> User { get { return new UserProp<InProp<FilterUserIds, int>>(); } }

		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }

		public Equal<FilterFromDate, DateTime> FromDate { get { return new Equal<FilterFromDate, DateTime>(); } }

		public Equal<FilterFilter, string> Filter { get { return new Equal<FilterFilter, string>(); } }

		public IdProp<FilterId> ReplyToUser { get { return new IdProp<FilterId>(); } }
	}
}
