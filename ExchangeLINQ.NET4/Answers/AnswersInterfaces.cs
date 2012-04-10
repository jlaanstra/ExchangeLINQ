using System.Collections.Generic;

namespace ExchangeLINQ.Answers
{
	public interface IAnswersIn
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

	public interface IAnswersQuestion
	{
		IAnswersId Question { get; }
	}

	public interface IAnswersId
	{
		IAnswersIn Id { get; }
	}

	public interface IAnswersPostingUser
	{
		IAnswersId PostingUser { get; }
	}
}
