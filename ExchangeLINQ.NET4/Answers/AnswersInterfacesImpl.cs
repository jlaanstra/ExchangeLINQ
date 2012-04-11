using System;
using System.Collections.Generic;
using System.Linq;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Answers
{
	internal class AnswersInterfacesImpl : IAnswersIdQuestionPostingUser
	{
		public IdProp<InCall<FilterQuestionIds, int>> Question
		{
			get { return new IdProp<InCall<FilterQuestionIds, int>>(); }
		}

		public InCall<FilterIds, int> Id
		{
			get { return new InCall<FilterIds, int>(); }
		}

		public IdProp<InCall<FilterUserIds, int>> PostingUser
		{
			get { return new IdProp<InCall<FilterUserIds, int>>(); }
		}
	}
}
