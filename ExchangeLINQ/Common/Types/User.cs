
namespace ExchangeLINQ.Common.Types
{
	public class UserProp<T> : IdProp<T> where T : new()
	{
		public FilterMe Me { get { return new FilterMe(); } }
	}
}
