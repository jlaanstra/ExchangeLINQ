using System;
using System.Collections.Generic;
using System.Net;
using System.Reactive.Linq;
using ExchangeLINQ.Models;
using Newtonsoft.Json;

#if SILVERLIGHT || WINDOWSPHONE
using ExchangeLINQ.GZip;
#endif

namespace ExchangeLINQ.Common.Processor
{
	public class WrapperProcessor<T> : ProcessorBase
	{
		/// <summary>
		/// Creates the tokens from the json string.
		/// </summary>
		/// <param name="json">The json.</param>
		/// <returns></returns>
		private IEnumerable<ResponseWrapper<T>> CreateWrapperFromJson(string json)
		{
			return new[] { JsonConvert.DeserializeObject<ResponseWrapper<T>>(json) };
		}

		/// <summary>
		/// Subscribes the specified observer.
		/// </summary>
		/// <param name="observer">The observer.</param>
		/// <returns></returns>
		public IDisposable Subscribe(IObserver<ResponseWrapper<T>> observer, string url)
		{
			IObservable<ResponseWrapper<T>> observable = from req in Observable.Return(this.CreateWebRequest(new Uri(url)))
														 from resp in Observable.FromAsyncPattern<WebResponse>(req.BeginGetResponse, req.EndGetResponse)()
														 from wrapper in this.CreateWrapperFromJson(resp.GetString())
														 select wrapper;

			return observable.Subscribe(observer);
		}		
	}
}
