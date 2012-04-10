using System.Collections.Generic;

namespace ExchangeLINQ.Comments
{
	public interface ICommentsId
	{
		ICommentsIn Id { get; }
	}

	public interface ICommentsIn
	{
		/// <summary>
		/// Method added to hook into the c# params syntax.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		IEnumerable<int> In(params int[] ids);

		/// <summary>
		/// Specified to enable intellisense in LINQ query.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		/// <returns></returns>
		IEnumerable<int> In(IEnumerable<int> ids);
	}

	public interface ICommentsQuestion
	{
		ICommentsId Question { get; }
	}

	public interface ICommentsPostingUser
	{
		ICommentsId PostingUser { get; }
	}

	public interface ICommentsReplyToUser
	{
		ICommentsId ReplyToUser { get; }
	}
}
