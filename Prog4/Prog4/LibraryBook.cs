using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    public class LibraryBook
    {
        public bool check = false;//makes the check out false 
        const int YEAR = 2018;//year 2018
        private string _title;//book's title
        private string _author;//book's author
        private string _publisher;//books publisher
        private int _copyright;//book's copyright year
        private string _callNumber;//book's call number
        //read-only property that gets the book's title
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        //read-only propert that gets the book's author
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        //read-only property that gets the book's publisher
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        //read-only property that gets the book's copyright year
        public int CopyrightYear
        {
            get { return _copyright; }
            set
            {
                if (value > 0)
                    _copyright = value;
                else
                    _copyright = YEAR;
            }
        }
        //read-only property that gets the book's call number
        public string CallNumber
        {
            get { return _callNumber; }
            set { _callNumber = value; }
        }
        //five-parameter constructor
        public LibraryBook(string title, string author, string publisher, int copyright, string call)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyright;
            CallNumber = call;
        }//end five-parameter constructor
        //checkout status
        public void CheckOut()
        {
            check = true;
        }
        //return to shelf
        public void ReturnToShelf()
        {
            check = false;
        }
        //is checked out
        public bool IsCheckedOut()
        {
            return check;
        }
        //return string representation of book object using properties
        public override string ToString()
        {
            return $"Title: {Title}{Environment.NewLine}Author: {Author}{Environment.NewLine}Publisher: {Publisher}{Environment.NewLine}Copyright year: {CopyrightYear}{Environment.NewLine}Call Number: {CallNumber}{Environment.NewLine}Checked Out: {check}{Environment.NewLine}";
        }//end method ToString
    }
}

