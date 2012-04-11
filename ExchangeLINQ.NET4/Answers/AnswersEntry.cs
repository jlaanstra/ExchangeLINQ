using System;
using System.Collections.Generic;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Answers
{
	public class AnswersEntry : ProcessorState<Answer>
	{
		private IOAuth oauth;
		private ISite site;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		internal AnswersEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.AnswersUrl;
		}

		/// <summary>
		/// Implements the Select query pattern.
		/// </summary>
		/// <param name="a">A.</param>
		/// <returns></returns>
		public AnswersFilteredById Where(Func<IAnswersIdQuestionPostingUser, FilterIds> f)
		{
			return new AnswersFilteredById(this.Url, f(new AnswersInterfacesImpl()));
		}

		public AnswersFilteredByQuestionId Where(Func<IAnswersIdQuestionPostingUser, FilterQuestionIds> f)
		{
			return new AnswersFilteredByQuestionId(this.Url, f(new AnswersInterfacesImpl()));
		}

		public AnswersFilteredByUserId Where(Func<IAnswersIdQuestionPostingUser, FilterUserIds> f)
		{
			return new AnswersFilteredByUserId(this.Url, f(new AnswersInterfacesImpl()));
		}
	}
}
