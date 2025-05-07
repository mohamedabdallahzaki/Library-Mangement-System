using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Library_User:User
    {
        // properties
        public LibraryCard UserCard { get; set; }

        // constructor

        public Library_User(string name) : base(name)
        {

        }

        public void BorrowBook(Book book)
        {
            // Code to borrow a book

        }

        public new void DisplayBooks(Library li)
        {
            li.Display();
        }
    }
}
