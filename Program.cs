using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args)
	{
		string name, job, contactInfo;
		
		Console.WriteLine("Enter your name: ");
		name = Console.ReadLine();
		Console.WriteLine("Enter your job: ");
		job = Console.ReadLine();
		Console.WriteLine("Enter your contact information: ");
		contactInfo = Console.ReadLine();

		Console.WriteLine("Hi my name is " + name + ". I work as a " + job + ". You can contact me via " + contactInfo);
	}
	
}
