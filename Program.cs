namespace Bootcamp;

class Program
{
	static void Main(string[] args)
	{
		//converting string into an integer
		int num = Convert.ToInt32("19");
		Console.WriteLine(num + 6);

		//calculator program with integers
		Console.Write("Enter a number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter another number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(num1 + num2);

		//calculator program with decimals
		Console.Write("Enter a number: ");
		double num3 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter another number: ");
		double num4 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine(num3 + num4);
	}
	
}
