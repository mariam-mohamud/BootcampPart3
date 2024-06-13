using System.Runtime.CompilerServices;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
	{
		Console.WriteLine(GetDay(80));
	}

	static string GetDay(int dayNum) 
	{
		string dayName;

		switch (dayNum) 
		{
			//in the case that the day number is 0, the day name will br sunday - then breaks out of the loop
			case 0:
			dayName = "Monday";
			break;

			case 1:
			dayName = "Tuesday";
			break;

			case 2:
			dayName = "Wednesday";
			break;

			case 3:
			dayName = "Thursday";
			break;

			case 4:
			dayName = "Friday";
			break;

			case 5:
			dayName = "Saturday";
			break;

			case 6:
			dayName = "Sunday";
			break;

			default:
			dayName = "Invalid";
			break;
		}
		return dayName;
	}
}