using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Answers
{
	public class AnswersFilteredById : ProcessorState<Answer>
	{
		private IEnumerable<int> ids;
		private string queryUrl = "/2.0/answers/{0}";
		private IOAuth oauth;
		private ISite site;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal AnswersFilteredById(IOAuth oauth, ISite site, IEnumerable<int> ids)
		{
			this.oauth = oauth;
			this.site = site;
			this.ids = ids;
		}
	}
}
