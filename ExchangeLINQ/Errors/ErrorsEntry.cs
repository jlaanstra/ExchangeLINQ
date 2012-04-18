using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Errors
{
	public class ErrorsEntry : ProcessorState<Error>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ErrorsEntry"/> class.
		/// </summary>
		/// <param name="token">The token.</param>
		internal ErrorsEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.ErrorsUrl;
		}

		public ErrorsFilteredById Where(Func<IdProp<FilterId>, FilterId> f)
		{
			return new ErrorsFilteredById(this.Url, f(new IdProp<FilterId>()));
		}
	}
}
