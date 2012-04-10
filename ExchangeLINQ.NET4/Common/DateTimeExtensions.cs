using System;

namespace ExchangeLINQ.Common
{
	public static class DateTimeExtensions
	{
		public static long ToUnixTimeStamp(this DateTime date)
		{
			return (long)(date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		}

		public static DateTime FromUnixTimeStamp(this long seconds)
		{
			var date = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			date = date.AddSeconds(seconds);
			return date;
		}
	}
}
