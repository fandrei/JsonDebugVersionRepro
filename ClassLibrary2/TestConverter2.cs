using System;
using System.Collections.Generic;
using System.Diagnostics;

using Newtonsoft.Json;

namespace ClassLibrary2
{
	public class TestConverter2<T> : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue(value);
		}

		public override bool CanConvert(Type objectType)
		{
			var res = objectType == typeof(T);
			return res;
		}

		public override bool CanRead => true;

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var val = reader.Value;
			return val;
		}
	}
}
