using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args)
	{
		int[] arrayName = {1, 2, 3};

		Console.WriteLine(arrayName[0]);
		
		//creates new array that holds 2 elements
		string[] friends = new string[2];
		friends[0] = "Jim";
		friends[1] = "Pam";

		Console.WriteLine(friends[1]);
	}
	
}
