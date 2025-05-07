using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int bookCount = 0;

        private Book[] BorrowBooks = new Book[50];
        private int BorrowBookCount = 0;


        public void AddBook(Book book)
        {
            if (bookCount < books.Length)
            {
                books[bookCount] =  book;
                bookCount++;
                Console.WriteLine("book add succ");
            }
            else
            {
                Console.WriteLine("Library is full, cannot add more books.");
            }

        }
        public void RemoveBook(Book book)
        {
           int IndexOfBook =  Array.IndexOf(books, book);
            books[IndexOfBook] = null;
            Console.WriteLine("You remove this book !");
            bookCount--;
        }

        public void Display() 
        {
            foreach (var book in books)
            {
                if (book != null)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}");
                }
            }
        }

        public void BorrowBook(Book book)
        {
            if (BorrowBookCount < BorrowBooks.Length)
            {
                BorrowBooks[BorrowBookCount] = book;
                BorrowBookCount++;
                Console.WriteLine("You borrow this book");
            }
            else
            {
                Console.WriteLine("You can't borrow more books");
            }
        }
    }
}
