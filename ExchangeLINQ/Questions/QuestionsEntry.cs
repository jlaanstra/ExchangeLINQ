using System;
using ExchangeLINQ.Common;
using ExchangeLINQ.Common.State;
using ExchangeLINQ.Complex;
using ExchangeLINQ.Models;
using System.Diagnostics.Contracts;

namespace ExchangeLINQ.Questions
{
	public class QuestionsEntry : ProcessorState<Question>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuestionsEntry"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal QuestionsEntry(ExchangeUrl url)
		{
			Contract.Requires(url != null);

			this.Url = url;
			this.Url.QueryUrl = UrlConstants.QuestionsUrl;
		}

		#region Questions
		
		public QuestionsFilteredById Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterIds> f)
		{
			FilterIds filter = f(new QuestionsInterfacesImpl());
			return new QuestionsFilteredById(this.Url, filter);
		}

		public QuestionsFilteredByTag Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterTags> f)
		{
			FilterTags filter = f(new QuestionsInterfacesImpl());
			return new QuestionsFilteredByTag(this.Url, filter);
		}

		public QuestionsFilteredByFeatured Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterFeatured> f)
		{
			return new QuestionsFilteredByFeatured(this.Url);
		}

		public QuestionsFilteredByUnanswered Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterUnanswered> f)
		{
			return new QuestionsFilteredByUnanswered(this.Url);
		}

		public QuestionsFilteredByNoAnswers Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterNoAnswers> f)
		{
			return new QuestionsFilteredByNoAnswers(this.Url);
		}

		public QuestionsFilteredByUserId Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterUserIds> f)
		{
			return new QuestionsFilteredByUserId(this.Url, f(new QuestionsInterfacesImpl()));
		}

		public QuestionsFilteredByMe Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterMe> f)
		{
			return new QuestionsFilteredByMe(this.Url, f(new QuestionsInterfacesImpl()));
		}

		#endregion

		#region Complex
		
		public FilteredByPage<Question> Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterPage> f)
		{
			FilterPage filter = f(new QuestionsInterfacesImpl());
			return new FilteredByPage<Question>(this.Url, filter);
		}

		public FilteredByFromDate<Question> Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterFromDate> f)
		{
			FilterFromDate filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFromDate<Question>(this.Url, filter);
		}

		public FilteredByFilter<Question> Where(Func<IQuestionIdTagsLinksToIsRelatedToPostingUserIsFeaturedIsUnansweredHasNoAnswersPageFromDateFilter, FilterFilter> f)
		{
			FilterFilter filter = f(new QuestionsInterfacesImpl());
			return new FilteredByFilter<Question>(this.Url, filter);
		}

		#endregion

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
