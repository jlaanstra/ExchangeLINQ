using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	internal class BadgesFilteredById : ProcessorState<Badge>
	{
		private FilterIds ids;

		/// <summary>
		/// Initializes a new instance of the <see cref="BadgesFilteredById"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		public BadgesFilteredById(ExchangeUrl url, FilterIds ids)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.BadgesByIdUrl, string.Join(";", ids.Value));

			this.ids = ids;
		}

		public BadgesFilteredByIdRecent Where(Func<IBadgesRecentlyAwardedPageFromDateFilter, FilterRecent> f)
		{
			return new BadgesFilteredByIdRecent(this.Url, ids);
		}

		#region Complex

		public FilteredByPage<Answer> Where(Func<IBadgesRecentlyAwardedPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new BadgesInterfacesImpl());
			return new FilteredByPage<Answer>(this.Url, filter);
		}

		public FilteredByFromDate<Answer> Where(Func<IBadgesRecentlyAwardedPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new BadgesInterfacesImpl());
			return new FilteredByFromDate<Answer>(this.Url, filter);
		}

		public FilteredByFilter<Answer> Where(Func<IBadgesRecentlyAwardedPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new BadgesInterfacesImpl());
			return new FilteredByFilter<Answer>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<Answer> OrderBy(Func<IBadgesOrderByNameRankType, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new BadgesInterfacesImpl());
			return new OrderBy<Answer>(this.Url, filter);
		}

		public OrderByDescending<Answer> OrderByDescending(Func<IBadgesOrderByNameRankType, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new BadgesInterfacesImpl());
			return new OrderByDescending<Answer>(this.Url, filter);
		}

		#endregion
	}
}
