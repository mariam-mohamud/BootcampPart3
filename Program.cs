using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Bootcamp;

class Program
{
	static void Main(string[] args) 
{
	Book book1 = new Book();
	book1.title = "the atlas paradox";
	book1.author = "Olivie Blake";
	book1.pages = 200;

	Console.WriteLine(book1);
}
 	class Book
	{
		public string title;
		public string author;
		public int pages;
	}
}
