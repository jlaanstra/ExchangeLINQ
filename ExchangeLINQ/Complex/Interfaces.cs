using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.Types;

namespace ExchangeLINQ.Complex
{
	public interface IPageFromDateFilter
	{
		Equal<FilterPage, int> Page { get; }
		Equal<FilterFromDate, DateTime> FromDate { get; }
		Equal<FilterFilter, string> Filter { get; }
	}

	public interface IPageFilter
	{
		Equal<FilterPage, int> Page { get; }
		Equal<FilterFilter, string> Filter { get; }
	}

	public interface IPage
	{
		Equal<FilterPage, int> Page { get; }
	}

	public interface IPageSizeFilter
	{
		Equal<FilterPageSize, int> PageSize { get; }
		Equal<FilterFilter, string> Filter { get; }
	}

	public interface IToDateFilter
	{
		Equal<FilterToDate, DateTime> ToDate { get; }
		Equal<FilterFilter, string> Filter { get; }
	}

	public interface IFilter
	{
		Equal<FilterFilter, string> Filter { get; }
	}

	public interface IOrderByActivityCreationScore : IOrderByCreationScore
	{
		FilterOrderBy Activity { get; }
	}

	public interface IOrderByCreationScore
	{
		FilterOrderBy Creation { get; }
		FilterOrderBy Score { get; }
	}
}
