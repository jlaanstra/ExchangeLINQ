using ExchangeLINQ.Models;

namespace ExchangeLINQ
{
	public interface IWrapperEvaluator<T> : IEvaluator<T>
	{
		IEvaluator<ResponseWrapper<T>> Wrapper();
	}
}
