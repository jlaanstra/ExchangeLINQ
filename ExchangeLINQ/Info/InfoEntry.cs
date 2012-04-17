using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Info
{
	public class InfoEntry : ProcessorState<InfoItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SEInbox"/> class.
		/// </summary>
		/// <param name="token">The token.</param>
		internal InfoEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.InfoUrl;
		}
	}
}
