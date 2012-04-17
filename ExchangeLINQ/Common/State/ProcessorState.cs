using System;
using System.Reactive.Linq;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common.Processor;

namespace ExchangeLINQ.Common.State
{
	public abstract class ProcessorState<T> : State, IEvaluator<T>
	{		
		/// <summary>
		/// Selects the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public IEvaluator<T> Select(Func<Empty, Empty> f)
		{
			return this;
		}


		/// <summary>
		/// Subscribes the specified observer.
		/// </summary>
		/// <param name="observer">The observer.</param>
		/// <returns></returns>
		public virtual IDisposable Subscribe(IObserver<T> observer)
		{
			return new Processor<T>().SubscribeList(observer, this.Url.ToString());
		}

		public virtual IEvaluator<ResponseWrapper<T>> Wrapper()
		{
			return new WrapperProcessorState<T>(this.Url);
		}

		/// <summary>
		/// Transform the IEvaluator instance into an Observable.
		/// </summary>
		/// <returns></returns>
		public IObservable<T> AsObservable()
		{
			return Observable.Create<T>(observer => this.Subscribe(observer));
		}
	}
}
