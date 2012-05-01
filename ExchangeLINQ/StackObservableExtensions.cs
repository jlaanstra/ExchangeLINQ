using System;
using System.Reactive;

namespace ExchangeLINQ
{
	public static class StackObservableExtensions
	{
		// Methods
		public static IDisposable Subscribe<T>(this IStackObservable<T> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return source.Subscribe<T>(Stubs<T>.Ignore, Stubs.Throw, Stubs.Nop);
		}

		public static IDisposable Subscribe<T>(this IStackObservable<T> source, Action<T> onNext)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (onNext == null)
			{
				throw new ArgumentNullException("onNext");
			}
			return source.Subscribe<T>(onNext, Stubs.Throw, Stubs.Nop);
		}

		public static IDisposable Subscribe<T>(this IStackObservable<T> source, Action<T> onNext, Action<Exception> onError)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (onNext == null)
			{
				throw new ArgumentNullException("onNext");
			}
			if (onError == null)
			{
				throw new ArgumentNullException("onError");
			}
			return source.Subscribe<T>(onNext, onError, Stubs.Nop);
		}

		public static IDisposable Subscribe<T>(this IStackObservable<T> source, Action<T> onNext, Action onCompleted)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (onNext == null)
			{
				throw new ArgumentNullException("onNext");
			}
			if (onCompleted == null)
			{
				throw new ArgumentNullException("onCompleted");
			}
			return source.Subscribe<T>(onNext, Stubs.Throw, onCompleted);
		}

		public static IDisposable Subscribe<T>(this IStackObservable<T> source, Action<T> onNext, Action<Exception> onError, Action onCompleted)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (onNext == null)
			{
				throw new ArgumentNullException("onNext");
			}
			if (onError == null)
			{
				throw new ArgumentNullException("onError");
			}
			if (onCompleted == null)
			{
				throw new ArgumentNullException("onCompleted");
			}
			return source.Subscribe(Observer.Create(onNext, onError, onCompleted));
		}
	}
}
