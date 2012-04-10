using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeLINQ.Answers
{
	internal class AnswersInterfacesImpl : IAnswersIn, IAnswersQuestion, IAnswersId, IAnswersPostingUser
	{
		/// <summary>
		/// Method added to hook into the c# params syntax.
		/// </summary>
		/// <param name="ids">The tokens.</param>
		/// <returns></returns>
		public IEnumerable<int> In(params int[] ids)
		{
			return this.In(ids.AsEnumerable<int>());
		}

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="ids">The tokens.</param>
		/// <returns></returns>
		public IEnumerable<int> In(IEnumerable<int> ids)
		{
			if (ids.Count() > 100)
			{
				throw new InvalidOperationException("You can only specify up to 100 ids.");
			}
			return ids;
		}

		public IAnswersId Question { get { return this; } }

		public IAnswersId PostingUser { get { return this; } }

		public IAnswersIn Id { get { return this; } }
	}
}
