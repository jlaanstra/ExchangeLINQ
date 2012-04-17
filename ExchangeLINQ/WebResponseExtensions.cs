using System.IO;
using System.Net;
using System.Text;

namespace ExchangeLINQ
{
	public static class WebResponseExtensions
	{
		/// <summary>
		/// Gets the string.
		/// </summary>
		/// <param name="webResponse">The web response.</param>
		/// <returns></returns>
		public static string GetString(this WebResponse webResponse)
		{
			using (var s = webResponse.GetResponseStream())
			{
				int read;
				StringBuilder sb = new StringBuilder();
				char[] buffer = new char[4096];
				using (var r = new StreamReader(s))
				{
					do
					{
						read = r.Read(buffer, 0, buffer.Length);
						sb.Append(buffer, 0, read);
					} while (read != 0);
				}
				return sb.ToString();
			}
		}
	}
}
