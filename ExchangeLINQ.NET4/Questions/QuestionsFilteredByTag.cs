using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;

namespace ExchangeLINQ.Questions
{
	public class QuestionsFilteredByTag : ProcessorState<Question>
	{
		private FilterTags tags;

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokensFilteredByTokens"/> class.
		/// </summary>
		/// <param name="tokens">The tokens.</param>
		internal QuestionsFilteredByTag(ExchangeUrl url, FilterTags tags)
		{
			if (url == null)
			{
				throw new ArgumentNullException("url");
			}
			if (tags == null)
			{
				throw new ArgumentNullException("tags");
			}
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

		public QuestionsOrderBy OrderBy(Func<IQuestionsOrderByActivityCreationScoreHotWeekMonth, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new QuestionsOrderBy(this.Url, filter);
		}

		public QuestionsOrderByDescending OrderByDescending(Func<IQuestionsOrderByActivityCreationScoreHotWeekMonth, FilterOrderBy> f)
		{
			FilterOrderBy filter = f(new QuestionsInterfacesImpl());
			return new QuestionsOrderByDescending(this.Url, filter);
		}

		#endregion

	}
}
