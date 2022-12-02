//Grading ID: C4517
//Program 4
//Due Date: 12/4/18
//CIS 199-75
//This program contains information about five library books and tests if they are still in or checked out.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates derived class objects
            LibraryBook book1 = new LibraryBook("Jurassic Park", "Michael Crichton", "Alfred A. Knopf", 1990, "4567");//book 1 info
            LibraryBook book2 = new LibraryBook("Jaws", "Peter Benchley", "Doubleday", 1974, "7865");// book 2 info 
            LibraryBook book3 = new LibraryBook("Ready Player One", "Ernest Cline", "Random House", 2011, "4635"); //book 3 info 
            LibraryBook book4 = new LibraryBook("Holes", "Louis Sachar", "Farrar, Straus and Giroux", 1998, "5468"); // boook 4 info 
            LibraryBook book5 = new LibraryBook("Forrest Gump", "Winston Groom", "Doubleday", 1986, "5646");//book 5 info 
            
            //create five-element books array
            LibraryBook[] books = new LibraryBook[5];
            //intitialize array with books 
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            

            //generically process each element in array books
            foreach (LibraryBook book in books)
            {
                Console.WriteLine(book);//invokes ToString 
            }
        }
    }
}
