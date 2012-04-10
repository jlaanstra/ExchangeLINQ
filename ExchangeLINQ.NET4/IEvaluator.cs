using System;

namespace ExchangeLINQ
{
	public interface IEvaluator<T>
	{
		IDisposable Subscribe(IObserver<T> observer);

		IObservable<T> AsObservable();
	}
}
