using System;
using System.Globalization;
using System.Windows.Media;
using Newtonsoft.Json;

namespace ExchangeLINQ.Common
{
	public class ColorConverter : JsonConverter
	{
		/// <summary>
		/// Determines whether this instance can convert the specified object type.
		/// </summary>
		/// <param name="objectType">Type of the object.</param>
		/// <returns>
		///   <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
		/// </returns>
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(Color);
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:Newtonsoft.Json.JsonConverter"/> can read JSON.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this <see cref="T:Newtonsoft.Json.JsonConverter"/> can read JSON; otherwise, <c>false</c>.
		/// </value>
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:Newtonsoft.Json.JsonConverter"/> can write JSON.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this <see cref="T:Newtonsoft.Json.JsonConverter"/> can write JSON; otherwise, <c>false</c>.
		/// </value>
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Reads the JSON representation of the object.
		/// </summary>
		/// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader"/> to read from.</param>
		/// <param name="objectType">Type of the object.</param>
		/// <param name="existingValue">The existing value of object being read.</param>
		/// <param name="serializer">The calling serializer.</param>
		/// <returns>
		/// The object value.
		/// </returns>
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.String)
			{
				throw new Exception(String.Format("Unexpected token parsing color. Expected String, got {0}.",reader.TokenType));
			}
			string colorString = reader.Value.ToString().TrimStart('#');
			uint argb;
			if(uint.TryParse(colorString, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out argb))
			{
				return Color.FromArgb((byte)((argb & -16777216) >> 24), (byte)((argb & 0xff0000) >> 16), (byte)((argb & 0xff00) >> 8), (byte)(argb & 0xff));
			}
			else
			{
				throw new ArgumentException();
			}
		}

		/// <summary>
		/// Writes the JSON representation of the object.
		/// </summary>
		/// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.</param>
		/// <param name="value">The value.</param>
		/// <param name="serializer">The calling serializer.</param>
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value is Color)
			{
				Color c = (Color)value;
				writer.WriteValue(string.Format("#{0:X2}{0:X2}{0:X2}{0:X2}", c.A, c.R, c.G, c.B));
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
	}
}
