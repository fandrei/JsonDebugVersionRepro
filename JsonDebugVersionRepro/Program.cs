using System;
using System.Diagnostics;
using System.Linq;
using ClassLibrary1;
using ClassLibrary2;
using Newtonsoft.Json;

namespace JsonDebugVersionRepro
{
	class Program
	{
		static void Main(string[] args)
		{
			var settings = new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				DefaultValueHandling = DefaultValueHandling.Ignore,
				NullValueHandling = NullValueHandling.Ignore,
				Converters =
				{
					new TestConverter1<int>(),
					new TestConverter2<int>(),
				}
			};

			Debugger.Break();
		}
	}
}
