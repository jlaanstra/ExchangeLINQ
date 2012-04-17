using System;
using System.Net;
using ExchangeLINQ.GZip.ZLib;

namespace ExchangeLINQ.GZip
{
	internal class GZipWebResponse : WebResponse
	{
		private WebResponse response;

		internal GZipWebResponse(WebResponse resp)
		{
			response = resp;
		}

		public override System.IO.Stream GetResponseStream()
		{
			return new GZipStream(response.GetResponseStream());
		}
		public override void Close()
		{
			response.Close();
		}
		public override long ContentLength
		{
			get { return response.ContentLength; }
		}
		public override string ContentType
		{
			get { return response.ContentType; }
		}
		public override WebHeaderCollection Headers
		{
			get { return response.Headers; }
		}
		public override Uri ResponseUri
		{
			get { return response.ResponseUri; }
		}
		public override bool SupportsHeaders
		{
			get { return response.SupportsHeaders; }
		}
	}
}
