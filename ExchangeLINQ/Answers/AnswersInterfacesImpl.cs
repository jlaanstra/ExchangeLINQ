using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Answers
{
	internal class AnswersInterfacesImpl : IAnswersIdQuestionPostingUserPageFromDateFilter
	{
		public IdProp<InProp<FilterQuestionIds, int>> Question { get { return new IdProp<InProp<FilterQuestionIds, int>>(); } }

		public InProp<FilterIds, int> Id { get { return new InProp<FilterIds, int>(); } }

		public IdProp<InProp<FilterUserIds, int>> PostingUser { get { return new IdProp<InProp<FilterUserIds, int>>(); } }

		public Equal<FilterPage, int> Page
		{
			get { return new Equal<FilterPage, int>(); }
		}

		public Equal<FilterFromDate, DateTime> FromDate
		{
			get { return new Equal<FilterFromDate, DateTime>(); }
		}

		public Equal<FilterFilter, string> Filter
		{
			get { return new Equal<FilterFilter, string>(); }
		}
	}
}
