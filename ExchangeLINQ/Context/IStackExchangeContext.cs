
using ExchangeLINQ.Answers;
using ExchangeLINQ.Questions;
using ExchangeLINQ.Search;
using ExchangeLINQ.Comments;
using ExchangeLINQ.Tags;
using ExchangeLINQ.Badges;
using ExchangeLINQ.Users;
using ExchangeLINQ.AccessTokens;
using ExchangeLINQ.Applications;
using ExchangeLINQ.Inbox;
using ExchangeLINQ.AssociatedUsers;
using ExchangeLINQ.Sites;
namespace ExchangeLINQ.Context
{
	public interface IStackExchangeContext : IOAuth
	{
		AccessTokensEntry AccessTokens();

		AnswersEntry Answers(string apiSiteParameter);

		ApplicationsEntry Applications();

		AssociatedUsersEntry AssociatedUsers();

		BadgesEntry Badges(string apiSiteParameter);

		CommentsEntry Comments(string apiSiteParameter);

		InboxEntry Inbox();

		QuestionsEntry Questions(string apiSiteParameter);

		SearchEntry Search(string apiSiteParameter);

		SitesEntry Sites();

		TagsEntry Tags(string apiSiteParameter);

		UsersEntry Users(string apiSiteParameter);
	}
}
