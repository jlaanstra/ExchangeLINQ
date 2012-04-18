using System;
using System.Net;

#if SILVERLIGHT || WINDOWSPHONE
using ExchangeLINQ.GZip;
#endif

namespace ExchangeLINQ.Common.Processor
{
	public class ProcessorBase
	{
		protected WebRequest CreateWebRequest(Uri url)
		{
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
