using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
     internal abstract class User
    {
        // properties
        public string? Name { get; set; }
        // constructor
        public User(string LibrarianName)
        {
            Name = LibrarianName;
        }

        public void DisplayBooks(Library li)
        { 

        }


    }
}
