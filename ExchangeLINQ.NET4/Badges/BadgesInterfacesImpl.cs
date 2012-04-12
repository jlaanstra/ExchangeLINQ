using System;
using System.Collections.Generic;
using System.Linq;
using ExchangeLINQ.Common.Types;
using ExchangeLINQ.Common;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Badges
{
	internal class BadgesInterfacesImpl : IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, IBadgesOrderByNameRankType, IBadgesOrderByNameRank,
		IBadgesRecentlyAwardedPageFromDateFilter
	{
		public Equal<FilterName, string> Name
		{
			get { return new Equal<FilterName, string>(); }
		}

		public InProp<FilterIds, int> Id
		{
			get { return new InProp<FilterIds, int>(); }
		}

		public FilterNonTagBased NonTagBased
		{
			get { return new FilterNonTagBased(); }
		}

		public FilterTagBased TagBased
		{
			get { return new FilterTagBased(); }
		}

		public FilterRecent IsRecentlyAwarded
		{
			get { return new FilterRecent(); }
		}

		public Equal<FilterPage, int> Page
		{
			get { return new Equal<FilterPage, int>(); }
		}

		public Equal<FilterFromDate, DateTime> FromDate
		{
			get { return new Equal<FilterFromDate, DateTime>(); }
		}

		public Equal<FilterFilter, string> Filter
		{
			get { return new Equal<FilterFilter, string>(); }
		}

		FilterOrderBy IBadgesOrderByNameRank.Name
		{
			get { return new FilterOrderBy() { Value = "name" }; }
		}

		public FilterOrderBy Rank
		{
			get { return new FilterOrderBy() { Value = "rank" }; }
		}

		public FilterOrderBy Type
		{
			get { return new FilterOrderBy() { Value = "type" }; }
		}		
	}
}
