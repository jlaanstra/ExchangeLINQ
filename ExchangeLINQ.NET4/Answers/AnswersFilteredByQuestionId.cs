using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Answers
{
	public class AnswersFilteredByQuestionId : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal AnswersFilteredByQuestionId(ExchangeUrl url, FilterIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.AnswersByQuestionIdUrl, string.Join(";", ids.Value));
		}
	}
}
