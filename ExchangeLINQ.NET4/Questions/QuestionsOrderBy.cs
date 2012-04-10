using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Questions
{
	public class QuestionsOrderBy : ProcessorState<Question>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsOrderBy"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		/// <param name="orderby">The orderby.</param>
		internal QuestionsOrderBy(ExchangeUrl url, FilterOrderBy orderby)
		{
			this.Url = url;
			this.Url.AddQueryOption("sort", orderby.Value);
			this.Url.AddQueryOption("order", "asc");
		}

		public FilteredByPage<Question> Where(Func<IPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new QuestionsInterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFilter<Question>(this.Url, filter);
		}
	}
}
