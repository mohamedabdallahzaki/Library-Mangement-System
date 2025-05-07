using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Librarian:User 
    {
        // properties
        public int EmployeeID { get; set; }
        // constructor

        public Librarian (string name):base(name)
        {
        
        }
        public void AddBook(Book book, Library library)
        {
            // Code to add book to the library
            library.AddBook(book);
        }

        public new  void DisplayBooks(Library li)
        {
            li.Display();
        }

        public void RemoveBook(Book book, Library li)
        {
            // Code to remove book from the library
            li.RemoveBook(book);

        }
        
    }
}
