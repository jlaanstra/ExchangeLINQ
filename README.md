# ExchangeLINQ

This library is a LINQ query provider for the Stack Exchange API v2. The beauty
of this thing is that it doesn't use expression trees and IQueryable, but instead
relies on the mapping from the query syntax to methods as Where and Select.
It is currently in alpha stage with some parts working and some parts not.
I developed the library as part of a stack exchange app for Windows Phone
I'm currently building with two other students.

## How to use it

Create a context with StackExchangeContext.Create.

Choose and endpoint: context.Questions.

Start querying: from q in context.Questions select q.
