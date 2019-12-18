using System;

namespace ConsoleCore
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			System.Console.WriteLine($"Environment.Version: {System.Environment.Version}");

			// Old result
			//   Environment.Version: 4.0.30319.42000
			//
			// New result
			//   Environment.Version: 3.0.0
			Console.WriteLine($"RuntimeInformation.FrameworkDescription: {System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}");
			Console.WriteLine("");
			//some comment
			// Old result
			//   RuntimeInformation.FrameworkDescription: .NET Core 4.6.27415.71
			//
			// New result
			//   RuntimeInformation.FrameworkDescription: .NET Core 3.0.0-preview4-27615-11
			Console.ReadKey();
		}
	}
}
