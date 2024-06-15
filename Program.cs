using System.Runtime.CompilerServices;
using System.Transactions;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
	
{
	int[,] numberGrid = {
		{1,2},
		{3,4},
		{5,6}
	};

	Console.WriteLine(numberGrid[1,1]);

	try
	{
		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter another number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(num1/num2);
	}
	catch (DivideByZeroException e)
	{
		Console.WriteLine(e.Message);
	}
	catch (FormatException e)
	{
		Console.WriteLine(e.Message);
	}
	finally
	{
	}
}
}