using System;

namespace lab4_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string string1 = "sdhifbhdrf ashfkjsdhf";
			string string2 = "sdhif ashfkjsdhf";
			string string3 = "sdhifbhdrf ashfkjsdhf";
			Console.Write("String 1:");
			Console.Write(string1);
			Console.Write("\nString 2:");
			Console.Write(string2);
			Console.Write("\nString 3:");
			Console.Write(string3);
			Console.WriteLine(" ");
			Console.WriteLine(string1 == string3);
			Console.WriteLine(Equals(string1, string2));
			Console.WriteLine(Equals(string1, string3));
			Console.ReadKey();

		}
	}
}