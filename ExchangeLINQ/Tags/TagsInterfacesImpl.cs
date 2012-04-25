using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeLINQ.Tags
{
	public class TagsInterfacesImpl : ITagsModeratorOnlyRequiredNamesUserPageFromDateFilter, ITagsOrderByNameActivityPopular
	{
		public FilterModeratorOnly ModeratorOnly { get { return new FilterModeratorOnly(); } }

		public FilterRequired Required { get { return new FilterRequired(); } }

		public ContainsIn Name { get { return new ContainsIn(); } }

		public Common.Types.UserProp<Common.Types.InProp<Common.FilterUserIds, int>> User { get { return new Common.Types.UserProp<Common.Types.InProp<Common.FilterUserIds, int>>(); } }

		public Common.Types.Equal<Complex.FilterPage, int> Page { get { return new Common.Types.Equal<Complex.FilterPage, int>(); } }

		public Common.Types.Equal<Complex.FilterFromDate, DateTime> FromDate { get { return new Common.Types.Equal<Complex.FilterFromDate, DateTime>(); } }

		public Common.Types.Equal<Complex.FilterFilter, string> Filter { get { return new Common.Types.Equal<Complex.FilterFilter, string>(); } }

		Common.FilterOrderBy ITagsOrderByNameActivityPopular.Name { get { return new Common.FilterOrderBy() { Value = "name" }; } }

		public Common.FilterOrderBy Activity { get { return new Common.FilterOrderBy() { Value = "activity" }; } }

		public Common.FilterOrderBy Popular { get { return new Common.FilterOrderBy() { Value = "popular" }; } }
	}
}
