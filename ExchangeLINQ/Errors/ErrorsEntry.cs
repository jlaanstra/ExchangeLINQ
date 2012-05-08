using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Errors
{
	public class ErrorsEntry : ProcessorState<Error>
	{
		public ErrorsFilteredById Where(Func<IdProp<FilterId>, FilterId> f)
		{
			return new ErrorsFilteredById(this.Url, f(new IdProp<FilterId>()));
		}
	}
}
