using System;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Complex
{
	public class InterfacesImpl : IPage, IPageSizeFilter, IPageFromDateFilter, IToDateFilter, IFilter, IPageFilter
	{
		public Equal<FilterPage, int> Page { get { return new Equal<FilterPage, int>(); } }

		public Equal<FilterToDate, DateTime> ToDate { get { return new Equal<FilterToDate, DateTime>(); } }

		public Equal<FilterFromDate, DateTime> FromDate { get { return new Equal<FilterFromDate, DateTime>(); } }

		public Equal<FilterPageSize, int> PageSize { get { return new Equal<FilterPageSize, int>(); } }

		public Equal<FilterFilter, string> Filter { get { return new Equal<FilterFilter, string>(); } }
	}
}
