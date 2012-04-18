using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredByFeatured : ProcessorState<Question>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsFilteredByFeatured"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal QuestionsFilteredByFeatured(ExchangeUrl url)
		{
			this.Url = url;
			this.Url.QueryUrl = UrlConstants.FeaturedQuestionsUrl;
		}

		public QuestionsFilteredByFeaturedTag Where(Func<IQuestionTagsPageFromDateFilter, FilterTags> f)
		{
			FilterTags filter = f(new QuestionsInterfacesImpl());
			return new QuestionsFilteredByFeaturedTag(this.Url, filter);
		}

		public FilteredByPage<Question> Where(Func<IQuestionTagsPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new QuestionsInterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IQuestionTagsPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IQuestionTagsPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFilter<Question>(this.Url, filter);
		}

		public OrderBy<Question> OrderBy(Func<IOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new OrderBy<Question>(this.Url, filter);
		}

		public OrderByDescending<Question> OrderByDescending(Func<IOrderByActivityCreationScore, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new OrderByDescending<Question>(this.Url, filter);
		}
	}
}
