using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Tags
{
	public class TagsEntry : ProcessorState<Tag>
	{
		internal TagsEntry(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.TagsUrl;
		}

		public TagsFilteredByModeratorOnly Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterModeratorOnly> f)
		{
			return new TagsFilteredByModeratorOnly(this.Url, f(new TagsInterfacesImpl()));
		}

		public TagsFilteredByRequired Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterRequired> f)
		{
			return new TagsFilteredByRequired(this.Url, f(new TagsInterfacesImpl()));
		}

		public TagsFilteredByNames Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterNames> f)
		{
			return new TagsFilteredByNames(this.Url, f(new TagsInterfacesImpl()));
		}

		public TagsFilteredByNameContains Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterNameContains> f)
		{
			return new TagsFilteredByNameContains(this.Url, f(new TagsInterfacesImpl()));
		}

		public TagsFilteredByUserId Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterUserIds> f)
		{
			return new TagsFilteredByUserId(this.Url, f(new TagsInterfacesImpl()));
		}

		public TagsFilteredByMe Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterMe> f)
		{
			return new TagsFilteredByMe(this.Url, f(new TagsInterfacesImpl()));
		}

		#region Complex

		public FilteredByPage<Tag> Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new TagsInterfacesImpl());
			return new FilteredByPage<Tag>(this.Url, filter);
		}

		public FilteredByFromDate<Tag> Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new TagsInterfacesImpl());
			return new FilteredByFromDate<Tag>(this.Url, filter);
		}

		public FilteredByFilter<Tag> Where(Func<ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new TagsInterfacesImpl());
			return new FilteredByFilter<Tag>(this.Url, filter);
		}

		#endregion

		#region OrderBy

		public OrderBy<Tag> OrderBy(Func<ITagsOrderByNameActivityPopular, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new TagsInterfacesImpl());
			return new OrderBy<Tag>(this.Url, filter);
		}

		public OrderByDescending<Tag> OrderByDescending(Func<ITagsOrderByNameActivityPopular, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new TagsInterfacesImpl());
			return new OrderByDescending<Tag>(this.Url, filter);
		}

		#endregion
	}
}
