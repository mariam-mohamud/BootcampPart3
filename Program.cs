using System.Runtime.CompilerServices;
using System.Transactions;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
	{
			Console.WriteLine(ExponentMethod(4,3));
	}

	static int ExponentMethod(int num1, int num2)
	{
		int emptyNum = 1;
		for (int i = 1; i <= num2; i++) 
		{
			emptyNum *= num1;
		}	
		return emptyNum;
	}
}