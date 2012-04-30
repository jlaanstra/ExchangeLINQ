using ExchangeLINQ.Answers;
using ExchangeLINQ.Common;
using ExchangeLINQ.Questions;
using ExchangeLINQ.Search;
using ExchangeLINQ.Comments;
using ExchangeLINQ.Tags;
using ExchangeLINQ.Badges;
using ExchangeLINQ.Users;
using ExchangeLINQ.AccessTokens;
using ExchangeLINQ.Sites;
using ExchangeLINQ.AssociatedUsers;
using ExchangeLINQ.Inbox;
using ExchangeLINQ.Applications;

namespace ExchangeLINQ.Context
{
	internal class StackExchangeContextImpl : IStackExchangeContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="StackExchangeContextImpl"/> class.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <param name="accessToken">The access token.</param>
		internal StackExchangeContextImpl(string key, string accessToken)
		{
			this.AccessToken = accessToken;
			this.Key = key;
		}

		/// <summary>
		/// Gets or sets the authentication token.
		/// </summary>
		public string AccessToken { get; set; }

		/// <summary>
		/// Gets or sets the authentication key.
		/// </summary>
		public string Key { get; set; }

		#region WithoutUsers
		
		/// <summary>
		/// Gets the access tokens endpoint.
		/// </summary>
		public AccessTokensEntry AccessTokens()
		{
			return new AccessTokensEntry(this.CreateUrl());
		}

		/// <summary>
		/// Gets the applications endpoint.
		/// </summary>
		public ApplicationsEntry Applications()
		{
			return new ApplicationsEntry(this.CreateUrl());
		}
		
		/// <summary>
		/// Gets the inbox endpoint.
		/// </summary>
		public InboxEntry Inbox()
		{
			return new InboxEntry(this.CreateUrl());
		}

		/// <summary>
		/// Gets the inbox endpoint.
		/// </summary>
		public AssociatedUsersEntry AssociatedUsers()
		{
			return new AssociatedUsersEntry(this.CreateUrl());
		}

		/// <summary>
		/// Gets the sites.
		/// </summary>
		public SitesEntry Sites()
		{
			return new SitesEntry(this.CreateUrl());
		}

		#endregion

		#region WithSites

		public AnswersEntry Answers(string apiSiteParameter)
		{
			return new AnswersEntry(this.CreateUrl(apiSiteParameter));
		}

		public BadgesEntry Badges(string apiSiteParameter)
		{
			return new BadgesEntry(this.CreateUrl(apiSiteParameter));
		}

		public CommentsEntry Comments(string apiSiteParameter)
		{
			return new CommentsEntry(this.CreateUrl(apiSiteParameter));
		}

		public QuestionsEntry Questions(string apiSiteParameter)
		{
			return new QuestionsEntry(this.CreateUrl(apiSiteParameter));
		}

		public SearchEntry Search(string apiSiteParameter)
		{
			return new SearchEntry(this.CreateUrl(apiSiteParameter));
		}

		public TagsEntry Tags(string apiSiteParameter)
		{
			return new TagsEntry(this.CreateUrl(apiSiteParameter));
		}

		public UsersEntry Users(string apiSiteParameter)
		{
			return new UsersEntry(this.CreateUrl(apiSiteParameter));
		}

		#endregion

		/// <summary>
		/// Creates the URL.
		/// </summary>
		/// <param name="apiSiteParameter">The API site parameter.</param>
		/// <returns></returns>
		private ExchangeUrl CreateUrl(string apiSiteParameter = null)
		{
			var url = new ExchangeUrl(this);
			if (!string.IsNullOrEmpty(apiSiteParameter))
			{
				url.AddQueryOption("site", apiSiteParameter);
			}
			return url;
		}
	}
}
