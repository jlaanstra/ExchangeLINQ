using ExchangeLINQ.Answers;
using ExchangeLINQ.Common;
using ExchangeLINQ.Questions;
using ExchangeLINQ.Search;
using ExchangeLINQ.Comments;
using ExchangeLINQ.Tags;
using ExchangeLINQ.Badges;
using ExchangeLINQ.Users;

namespace ExchangeLINQ.Context
{
	internal class SiteStackExchangeContext : ISiteStackExchangeContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NetworkStackExchangeContext"/> class.
		/// </summary>
		/// <param name="apiKey">The API key.</param>
		internal SiteStackExchangeContext(string key, string accessToken, string apiSiteParameter)
		{
			this.AccessToken = accessToken;
			this.Key = key;
			this.ApiSiteParameter = apiSiteParameter;
		}

		/// <summary>
		/// Gets or sets the authentication token.
		/// </summary>
		public string AccessToken { get; set; }

		/// <summary>
		/// Gets or sets the authentication key.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Gets or sets the API site parameter.
		/// </summary>
		public string ApiSiteParameter { get; set; }

		public AnswersEntry Answers
		{
			get 
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter);
				return new AnswersEntry(url);
			}
		}

		public QuestionsEntry Questions
		{
			get 
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter); 
				return new QuestionsEntry(url);
			}
		}

		public SearchEntry Search
		{
			get
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter);
				return new SearchEntry(url);
			}
		}


		public CommentsEntry Comments
		{
			get
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter);
				return new CommentsEntry(url);
			}
		}

		public TagsEntry Tags
		{
			get
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter);
				return new TagsEntry(url);
			}
		}

		public BadgesEntry Badges
		{
			get
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter);
				return new BadgesEntry(url);
			}
		}

		public UsersEntry Users
		{
			get
			{
				var url = new ExchangeUrl(this);
				url.AddQueryOption("site", this.ApiSiteParameter);
				return new UsersEntry(url);
			}
		}
	}
}
