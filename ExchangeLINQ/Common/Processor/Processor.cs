using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
using System.Net;
using System.Reactive.Linq;
using ExchangeLINQ.Models;
using Newtonsoft.Json;

#if SILVERLIGHT && !WINDOWS_PHONE
using System.Windows.Browser;
#endif
#if !SILVERLIGHT
using System.Web;
#endif

namespace ExchangeLINQ.Common.Processor
{
	public class Processor<T> : ProcessorBase
	{
		/// <summary>
		/// Creates the tokens from the json string.
		/// </summary>
		/// <param name="json">The json.</param>
		/// <returns></returns>
		private IEnumerable<T> CreateListFromJson(string json)
		{
			return JsonConvert.DeserializeObject<ResponseWrapper<T>>(json).Items;
		}

		/// <summary>
		/// Creates the tokens from the json string.
		/// </summary>
		/// <param name="json">The json.</param>
		/// <returns></returns>
		private IEnumerable<T> CreateSingleFromJson(string json)
		{
			T obj = JsonConvert.DeserializeObject<T>(HttpUtility.HtmlDecode(json));
			return new T[] { obj };
		}

		/// <summary>
		/// Subscribes the specified observer.
		/// </summary>
		/// <param name="observer">The observer.</param>
		/// <returns></returns>
		public IDisposable SubscribeSingle(IObserver<T> observer, string url)
		{
			Contract.Requires(url != null);
			Contract.Requires(observer != null);

			IObservable<T> observable = from req in Observable.Return(this.CreateWebRequest(new Uri(url)))
										from resp in Observable.FromAsyncPattern<WebResponse>(req.BeginGetResponse, req.EndGetResponse)()
										from token in this.CreateSingleFromJson(resp.GetString())
										select token;

			return observable.Subscribe(observer);
		}

		/// <summary>
		/// Subscribes the specified observer.
		/// </summary>
		/// <param name="observer">The observer.</param>
		/// <returns></returns>
		public IDisposable SubscribeList(IObserver<T> observer, string url)
		{
			Contract.Requires(url != null);
			Contract.Requires(observer != null);

			IObservable<T> observable = from req in Observable.Return(this.CreateWebRequest(new Uri(url)))
											from resp in Observable.FromAsyncPattern<WebResponse>(req.BeginGetResponse, req.EndGetResponse)()
											from token in this.CreateListFromJson(resp.GetString())
											select token;

			return observable.Subscribe(observer);
		}
	}
}
