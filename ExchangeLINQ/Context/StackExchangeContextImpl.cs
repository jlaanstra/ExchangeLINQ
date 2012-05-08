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
using ExchangeLINQ.Errors;

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
			return new AccessTokensEntry() { Url = this.CreateUrl() };
		}

		/// <summary>
		/// Gets the applications endpoint.
		/// </summary>
		public ApplicationsEntry Applications()
		{
			return new ApplicationsEntry() { Url = this.CreateUrl() };
		}

		/// <summary>
		/// Errorses this instance.
		/// </summary>
		/// <returns></returns>
		public ErrorsEntry Errors()
		{
			ExchangeUrl url = this.CreateUrl();
			url.QueryUrl = UrlConstants.ErrorsUrl;
			return new ErrorsEntry() { Url = url };
		}
		
		/// <summary>
		/// Gets the inbox endpoint.
		/// </summary>
		public InboxEntry Inbox()
		{
			ExchangeUrl url = this.CreateUrl();
			url.QueryUrl = UrlConstants.InboxUrl;
			return new InboxEntry() { Url = url };
		}

		/// <summary>
		/// Gets the inbox endpoint.
		/// </summary>
		public AssociatedUsersEntry AssociatedUsers()
		{
			ExchangeUrl url = this.CreateUrl();
			url.QueryUrl = UrlConstants.AssociatedMeUrl;
			return new AssociatedUsersEntry() { Url = url };
		}

		/// <summary>
		/// Gets the sites.
		/// </summary>
		public SitesEntry Sites()
		{
			ExchangeUrl url = this.CreateUrl();
			url.QueryUrl = UrlConstants.SitesUrl;
			return new SitesEntry() { Url = url };
		}

		#endregion

		#region WithSites

		public AnswersEntry Answers(string apiSiteParameter)
		{
			ExchangeUrl url = this.CreateUrl(apiSiteParameter);
			url.QueryUrl = UrlConstants.AnswersUrl;
			return new AnswersEntry() { Url = url };
		}

		public BadgesEntry Badges(string apiSiteParameter)
		{
			ExchangeUrl url = this.CreateUrl(apiSiteParameter);
			url.QueryUrl = UrlConstants.BadgesUrl;
			return new BadgesEntry() { Url = this.CreateUrl(apiSiteParameter) };
		}

		public CommentsEntry Comments(string apiSiteParameter)
		{
			ExchangeUrl url = this.CreateUrl(apiSiteParameter);
			url.QueryUrl = UrlConstants.CommentsUrl;
			return new CommentsEntry() { Url = this.CreateUrl(apiSiteParameter) };
		}

		public QuestionsEntry Questions(string apiSiteParameter)
		{
			ExchangeUrl url = this.CreateUrl(apiSiteParameter);
			url.QueryUrl = UrlConstants.QuestionsUrl;
			return new QuestionsEntry() { Url = url };
		}

		public SearchEntry Search(string apiSiteParameter)
		{
			ExchangeUrl url = this.CreateUrl(apiSiteParameter);
			url.QueryUrl = UrlConstants.SearchUrl;
			return new SearchEntry() { Url = url };
		}

		public TagsEntry Tags(string apiSiteParameter)
		{
			ExchangeUrl url = this.CreateUrl(apiSiteParameter);
			url.QueryUrl = UrlConstants.TagsUrl;
			return new TagsEntry() { Url = url };
		}

		public UsersEntry Users(string apiSiteParameter)
		{
			return new UsersEntry() { Url = this.CreateUrl(apiSiteParameter) };
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
