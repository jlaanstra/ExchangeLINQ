using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Errors
{
	public class ErrorsFilteredById : ProcessorState<Error>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ErrorsFilteredById"/> class.
		/// </summary>
		/// <param name="id">The id.</param>
		internal ErrorsFilteredById(ExchangeUrl url, FilterId id)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.ErrorsByIdUrl, id.Value);
		}
	}
}
