using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ExchangeLINQ.Common
{
    public class UnixTimestampConverter : DateTimeConverterBase
    {
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
            if (reader.TokenType != JsonToken.Integer)
            {
				return null;
                /*throw new Exception(
                    String.Format("Unexpected token parsing date. Expected Integer, got {0}.",
                    reader.TokenType));*/
            }

            var ticks = (long)reader.Value;
			
            return ticks.FromUnixTimeStamp();
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
        {

			if (value is DateTime)
			{
				DateTime dt = (DateTime)value;
				writer.WriteValue(dt.ToUnixTimeStamp());
			}
        }
    }
}
