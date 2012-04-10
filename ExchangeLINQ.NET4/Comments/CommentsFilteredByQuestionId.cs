using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Comments
{
	public class CommentsFilteredByQuestionId : ProcessorState<Comment>
	{
		private IEnumerable<int> ids;
		private string queryUrl = "/2.0/questions/{ids}/comments";
		private IOAuth oauth;
		private ISite site;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		public CommentsFilteredByQuestionId(IOAuth oauth, ISite site, IEnumerable<int> ids)
		{
			this.oauth = oauth;
			this.site = site;
			this.ids = ids;
		}
	}
}
