using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
	{
		//while a condition is true, loop
		int index = 1;
		while (index <= 5)
		{
			Console.WriteLine(index);
			index++;
		}

		//do while loop
		do
		{
			Console.WriteLine(index);
			index++;
		} while (index <= 5);

		//for loop - iterating variable (change everytime we go throug the loop)
		for (int i = 1; i <= 5; i++)
		{
			Console.WriteLine(i);
		}

	}
}