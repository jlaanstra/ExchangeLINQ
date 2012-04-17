using System;
using System.Reactive.Linq;
using ExchangeLINQ.Models;
using ExchangeLINQ.Common.Processor;

namespace ExchangeLINQ.Common.State
{
	public class WrapperProcessorState<T> : State, IEvaluator<ResponseWrapper<T>>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WrapperProcessorState&lt;T&gt;"/> class.
		/// </summary>
		/// <param name="url">The URL.</param>
		internal WrapperProcessorState(ExchangeUrl url)
		{
			this.Url = url;
		}

		// <summary>
		/// Selects the specified f.
		/// </summary>
		/// <param name="f">The f.</param>
		/// <returns></returns>
		public IEvaluator<ResponseWrapper<T>> Select(Func<Empty, Empty> f)
		{
			return this;
		}

		/// <summary>
		/// Subscribes the specified observer.
		/// </summary>
		/// <param name="observer">The observer.</param>
		/// <returns></returns>
		public virtual IDisposable Subscribe(IObserver<ResponseWrapper<T>> observer)
		{
			return new WrapperProcessor<T>().Subscribe(observer, this.Url.ToString());
		}

		/// <summary>
		/// Transform the IEvaluator instance into an Observable.
		/// </summary>
		/// <returns></returns>
		public IObservable<ResponseWrapper<T>> AsObservable()
		{
			return Observable.Create<ResponseWrapper<T>>(observer => this.Subscribe(observer));
		}
	}
}
