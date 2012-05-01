using System;

namespace ExchangeLINQ
{
	public interface IStackObservable<T>
	{
		IDisposable Subscribe(IObserver<T> observer);

		IObservable<T> ToObservable();
	}
}
