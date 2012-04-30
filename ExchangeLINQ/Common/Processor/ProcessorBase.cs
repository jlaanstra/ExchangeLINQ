using System;
using System.Net;
using System.Diagnostics.Contracts;

#if SILVERLIGHT || WINDOWSPHONE
using ExchangeLINQ.GZip;
#endif

namespace ExchangeLINQ.Common.Processor
{
	public class ProcessorBase
	{
		protected WebRequest CreateWebRequest(Uri url)
		{
			Contract.Requires(url != null);
#if SILVERLIGHT || WINDOWSPHONE
			return new GZipHttpWebRequest(url);
#else
			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
			req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			return req;
#endif
		}
	}
}
