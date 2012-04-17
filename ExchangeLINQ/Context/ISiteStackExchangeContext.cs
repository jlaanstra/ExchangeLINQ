
using ExchangeLINQ.Answers;
using ExchangeLINQ.Questions;
using ExchangeLINQ.Search;
namespace ExchangeLINQ.Context
{
	public interface ISiteStackExchangeContext : IOAuth, ISite
	{
		QuestionsEntry Questions { get; }

		AnswersEntry Answers { get; }

		SearchEntry Search { get; }
	}
}
