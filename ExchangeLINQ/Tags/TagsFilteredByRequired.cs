﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Common;
using ExchangeLINQ.Models;
using ExchangeLINQ.Complex;

namespace ExchangeLINQ.Tags
{
	public class TagsFilteredByRequired : ProcessorState<Tag>
	{
		internal TagsFilteredByRequired(ExchangeUrl url, FilterRequired required)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.RequiredTagsUrl);
		}

		#region Complex

		public FilteredByPage<Question> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new InterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new InterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new InterfacesImpl());
			return new FilteredByFilter<Question>(this.Url, filter);
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
