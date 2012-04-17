using System;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;

namespace ExchangeLINQ.Complex
{
	public class InterfacesImpl : IPage, IPageSizeFilter, IPageFromDateFilter, IToDateFilter, IFilter, IPageFilter, IOrderByActivityCreationScore
	{
		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }

		public Equal<FilterToDate, DateTime> ToDate { get { return new Equal<FilterToDate, DateTime>(); } }

		public Equal<FilterFromDate, DateTime> FromDate { get { return new Equal<FilterFromDate, DateTime>(); } }

		public Equal<FilterPageSize, int> PageSize { get { return new Equal<FilterPageSize, int>(); } }

		public Equal<FilterFilter, string> Filter { get { return new Equal<FilterFilter, string>(); } }

		public FilterOrderBy Activity { get { return new FilterOrderBy() { Value = "activity" }; } }

		public FilterOrderBy Creation { get { return new FilterOrderBy() { Value = "creation" }; } }

		public FilterOrderBy Score { get { return new FilterOrderBy() { Value = "votes" }; } }
	}
}
