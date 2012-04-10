using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Sites
{
	public class SitesEntry : ProcessorState<Site>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SitesEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		internal SitesEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.SitesUrl;
		}
	}
}
