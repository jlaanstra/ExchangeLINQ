using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeLINQ.Comments
{
	public class CommentsInterfacesImpl : ICommentsId, ICommentsIn, ICommentsQuestion, ICommentsPostingUser, ICommentsReplyToUser
	{
		public ICommentsIn Id { get { return this; } }

		public IEnumerable<int> In(params int[] ids)
		{
			return In(ids.AsEnumerable());
		}

		public IEnumerable<int> In(IEnumerable<int> ids)
		{
			if (ids.Count() > 100)
			{
				throw new InvalidOperationException("You can only specify up to 100 ids.");
			}
			return ids;
		}

		public ICommentsId Question { get { return this; } }

		public ICommentsId PostingUser { get { return this; } }

		public ICommentsId ReplyToUser { get { return this; } }
	}
}
