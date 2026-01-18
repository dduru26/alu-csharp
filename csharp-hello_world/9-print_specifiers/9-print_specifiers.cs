using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0:F2}%", percent * 100);
		Console.WriteLine("Currency: {0:C}", currency);
	}
}
