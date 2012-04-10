
namespace ExchangeLINQ.Common.Types
{
	public class IdProp<T> where T : new()
	{
		T Id { get { return new T(); } }
	}
}
