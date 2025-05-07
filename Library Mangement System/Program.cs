namespace Library_Mangement_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To The Library System: ");
            // library object
            Library library = new Library();

            // Type of user
            Console.Write("You are librarian or regular user (L/R) : ");
            // Type of user
            char TypeOfUser = Console.ReadLine().ToUpper()[0];

                if (TypeOfUser == 'L')
                {
                    // nae of the librarian
                    Console.Write("Welcome Librarian , Enter your name: ");
                    string? LibrarainName = Console.ReadLine();
                    // welcome the librarian
                    Librarian l1 = new Librarian(LibrarainName);
                    Console.WriteLine($"Welcome {l1.Name}");

                while (true)
                {
                    // opeartion of the librarian
                    Console.WriteLine("Please to add book (A) / Remove (R) / Display (D)");
                    char Operation = Console.ReadLine().ToUpper()[0];

                    switch (Operation)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details to add book");
                            // book name
                            Console.Write("Enter book name : ");
                            string? BookName = Console.ReadLine();
                            // book author
                            Console.Write("Enter book author :");
                            string? BookAuthor = Console.ReadLine();
                            // book year
                            Console.Write("Enter book year");
                            int BookYear = int.Parse(Console.ReadLine());
                            Book book = new Book() { Author = BookAuthor, Title = BookName, Year = BookYear };
                            // add book to the library
                            l1.AddBook(book, library);
                            break;


                        case 'R':
                            Console.WriteLine("Enter book details to remove book");
                            // book name
                            Console.Write("Enter book name : ");
                            string? BookNameToRemove = Console.ReadLine();
                            // book author
                            Console.Write("Enter book author :");
                            string? BookAuthorToRemove = Console.ReadLine();
                            // book year
                            Console.Write("Enter book year");
                            int BookYearToRemove = int.Parse(Console.ReadLine());
                            Book bookToRemove = new Book() { Author = BookAuthorToRemove, Title = BookNameToRemove, Year = BookYearToRemove };
                            // remove book from the library
                            l1.RemoveBook(bookToRemove, library);
                            break;
                        case 'D':
                            Console.WriteLine("The book list");
                            // display book
                            l1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }
                    }
                }
                else if (TypeOfUser == 'R')
                {
                // nae of the librarian
                Console.Write("Welcome Regular User , Enter your name: ");
                string? RegularUserName = Console.ReadLine();
                // welcome the librarian
                Library_User library_User = new Library_User(RegularUserName);
                Console.WriteLine($"Welcome {library_User.Name}");

            }
                else
                {
                    Console.WriteLine("Invalid input Please enter (L/R)");
                }

            
        }
    }
}
