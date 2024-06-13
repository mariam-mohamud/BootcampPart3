using System.Runtime.CompilerServices;
using System.Transactions;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
	{
		string secretWord = "mariam";
		string guess = "";
		int guessCount = 0;
		bool OutOfGuesses = false;

		
		while (guess != secretWord && !OutOfGuesses) 
		{
			if (guessCount < 3)
			{
			    Console.Write("Enter guess: ");
			    guess = Console.ReadLine();
			    guessCount++;
			}
			else 
			{
			    OutOfGuesses = true;
				Console.WriteLine("You lose :(");
		    }
		}
			if (OutOfGuesses)
			{
				Console.WriteLine("You ran out of guesses :(");
			}
			else 
			{
				Console.WriteLine("YAY!");
			}

	
}
}