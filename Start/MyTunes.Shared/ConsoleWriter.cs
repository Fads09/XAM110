using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTunes
{
	public static class ConsoleWriter
	{        
		public static void Write()
		{
#if __IOS__
            Console.WriteLine("iOS is hit");
#elif __ANDROID__
			Console.WriteLine("Android is hit");
#else
            Console.WriteLine("None are hit");
#endif
		}
	}
}

