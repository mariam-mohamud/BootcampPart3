using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args)
	{
		string colour, pluralNoun, name;

		Console.Write("Enter a colour: ");
		colour = Console.ReadLine();

		Console.Write("Enter a plural noun: ");
		pluralNoun = Console.ReadLine();

		Console.Write("Enter a name: ");
		name = Console.ReadLine();


		Console.WriteLine("Roses are " + colour);
		Console.WriteLine(pluralNoun + " are blue");
		Console.WriteLine("I love " + name);

	}
	
}
