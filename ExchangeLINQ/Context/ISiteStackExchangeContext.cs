
using ExchangeLINQ.Answers;
using ExchangeLINQ.Questions;
using ExchangeLINQ.Search;
using ExchangeLINQ.Comments;
using ExchangeLINQ.Tags;
using ExchangeLINQ.Badges;
using ExchangeLINQ.Users;
namespace ExchangeLINQ.Context
{
	public interface ISiteStackExchangeContext : IOAuth, ISite
	{
		QuestionsEntry Questions { get; }

		AnswersEntry Answers { get; }

		CommentsEntry Comments { get; }

		SearchEntry Search { get; }

		TagsEntry Tags { get; }

		BadgesEntry Badges { get; }

		UsersEntry Users { get; }
	}
}
