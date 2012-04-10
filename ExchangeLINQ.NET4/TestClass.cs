using System;

namespace ExchangeLINQ
{
	public class TestClass
	{
		public TestClass()
		{
			
		}

		public void TestMethod()
		{
			var x = from question in StackExchangeContext.CreateSiteSpecific(string.Empty, string.Empty).Questions
					orderby question.Hot
					where question.FromDate == new DateTime()
					where question.ToDate == new DateTime()
					where question.Page == 1
					where question.PageSize == 30
					select question;

			var y = from question in StackExchangeContext.CreateSiteSpecific(string.Empty, string.Empty).Questions
					where question.Tags.In("c#")
					orderby question.Activity descending
					select question;
		}
	}
}
