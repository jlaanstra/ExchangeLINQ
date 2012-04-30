using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Info
{
	public class InfoEntry : ProcessorState<InfoItem>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InfoEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal InfoEntry(ExchangeUrl url)
		{
			Contract.Requires(url != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.InfoUrl;
		}
	}
}
