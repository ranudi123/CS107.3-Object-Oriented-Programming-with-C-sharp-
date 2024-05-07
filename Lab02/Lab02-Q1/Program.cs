using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q1
{
   public class Book
    {
        public string Title;
        public string Author;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "Oliver twist";
            book1.Author = "Charles Dickens";

            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
            Console.ReadLine();

        }
    }
}
