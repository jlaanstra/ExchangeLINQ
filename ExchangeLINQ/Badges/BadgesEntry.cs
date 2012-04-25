using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Badges
{
	public class BadgesEntry : ProcessorState<Badge>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensEntry"/> class.
		/// </summary>
		/// <param name="oauth">The oauth.</param>
		internal BadgesEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.BadgesUrl;
		}

		public BadgesFilteredById Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterIds> f)
		{
			return new BadgesFilteredById(this.Url, f(new BadgesInterfacesImpl()));
		}

		public BadgesFilteredByName Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterName> f)
		{
			return new BadgesFilteredByName(this.Url, f(new BadgesInterfacesImpl()));
		}

		public BadgesFilteredByNonTagBased Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterNonTagBased> f)
		{
			return new BadgesFilteredByNonTagBased(this.Url);
		}

		public BadgesFilteredByTagBased Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterTagBased> f)
		{
			return new BadgesFilteredByTagBased(this.Url);
		}

		public BadgesFilteredByRecent Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterRecent> f)
		{
			return new BadgesFilteredByRecent(this.Url);
		}

		#region Complex

		public FilteredByPage<Answer> Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new BadgesInterfacesImpl());
			return new FilteredByPage<Answer>(this.Url, filter);
		}

		public FilteredByFromDate<Answer> Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new BadgesInterfacesImpl());
			return new FilteredByFromDate<Answer>(this.Url, filter);
		}

		public FilteredByFilter<Answer> Where(Func<IBadgesNameIdsNonTagBasedRecentlyAwardedTagBasedPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new BadgesInterfacesImpl());
			return new FilteredByFilter<Answer>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<Badge> OrderBy(Func<IBadgesOrderByNameRankType, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new BadgesInterfacesImpl());
			return new OrderBy<Badge>(this.Url, filter);
		}

		public OrderByDescending<Badge> OrderByDescending(Func<IBadgesOrderByNameRankType, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new BadgesInterfacesImpl());
			return new OrderByDescending<Badge>(this.Url, filter);
		}

		#endregion
	}
}
