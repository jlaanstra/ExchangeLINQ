using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredByTag : ProcessorState<Question>
	{
		private FilterTags tags;

		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsFilteredByTag"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="tags">The tags.</param>
		internal QuestionsFilteredByTag(ExchangeUrl url, FilterTags tags)
		{
			Contract.Requires(url != null);
			Contract.Requires(tags != null);

			this.Url = url;
			this.tags = tags;
			this.Url.AddQueryOption("tagged", String.Join(";", tags.Value));
		}

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

		#region OrderBy

		public OrderBy<Question> OrderBy(Func<IOrderByActivityCreationScoreHotWeekMonth, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new OrderBy<Question>(this.Url, filter);
		}

		public OrderByDescending<Question> OrderByDescending(Func<IOrderByActivityCreationScoreHotWeekMonth, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new OrderByDescending<Question>(this.Url, filter);
		}

		#endregion

	}
}
