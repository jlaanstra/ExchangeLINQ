using ExchangeLINQ.Models;

namespace ExchangeLINQ
{
	public interface IWrapperStackObservable<T> : IStackObservable<T>
	{
		IStackObservable<ResponseWrapper<T>> Wrapper();
	}
}
