using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args)
	{
		SayHi("Mariam", 19);
		SayHi("Dwight", 35);

		//will return default value of england
		NameACountry();
		//overrides default value and return thailand
		NameACountry("Thailand");

		//method called will return x*2
		Console.WriteLine(Multiply(4));

		//key:value syntax
		YoungestChild(child3: "Mariam", child2: "Omar", child1: "Yonis");
	}
	
	static void SayHi(string name, int age) 
	{
		Console.WriteLine("Hi " + name + " you are " + age);
	}

	//default parameter value
	static void NameACountry(string country = "England") 
	{
		Console.WriteLine(country);
	}

	//return values - integers
	static int Multiply(int x) 
	{
		return x * 2;
	}

	//send arguement with key:value syntax
	static void YoungestChild(string child1, string child2, string child3)
	{
		Console.WriteLine("The youngest child is " + child3);
	}
}
