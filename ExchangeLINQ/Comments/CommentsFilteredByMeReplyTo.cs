﻿using System.Collections.Generic;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Context;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common;
using ExchangeLINQ.Complex;
using System;

namespace ExchangeLINQ.Comments
{
	internal class CommentsFilteredByMeReplyTo : ProcessorState<Answer>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommentsFilteredByUserIdReplyTo"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="ids">The ids.</param>
		internal CommentsFilteredByMeReplyTo(ExchangeUrl url, FilterToId toid)
		{
			this.Url = url;
			this.Url.QueryUrl = string.Format(UrlConstants.CommentsToUserIdByMeUrl, toid);
		}

		#region Complex

		public FilteredByPage<Comment> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			return new FilteredByPage<Comment>(this.Url, f(new InterfacesImpl()));
		}

		public FilteredByFromDate<Comment> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			return new FilteredByFromDate<Comment>(this.Url, f(new InterfacesImpl()));
		}

		public FilteredByFilter<Comment> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			return new FilteredByFilter<Comment>(this.Url, f(new InterfacesImpl()));
		}

		#endregion

		#region OrderBy

		public OrderBy<Comment> OrderBy(Func<IOrderByCreationScore, FilterOrderBy> f)
		{
			return new OrderBy<Comment>(this.Url, f(new InterfacesImpl()));
		}

		public OrderByDescending<Comment> OrderByDescending(Func<IOrderByCreationScore, FilterOrderBy> f)
		{
			return new OrderByDescending<Comment>(this.Url, f(new InterfacesImpl()));
		}

		#endregion
	}
}