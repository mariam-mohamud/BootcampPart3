using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
	{
		bool isMale = true;
		bool isTall = false;

		if (isMale && isTall) 
		{
			Console.WriteLine("You are male & tall");
		} else if (isMale && !isTall)
		{
			Console.WriteLine("You are male & not tall");
		} else if (!isMale && isTall)
		{
			Console.WriteLine("You are not male & tall");
		} else 
		{
			Console.WriteLine("You are not male & not tall");
		}
		
}
}