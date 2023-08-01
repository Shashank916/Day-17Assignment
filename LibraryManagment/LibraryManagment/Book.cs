using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; private set; }

        public Book()
        {
            IsAvailable = true; 
        }

        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Book successfully borrowed.");
            }
            else
            {
                Console.WriteLine("Sorry, the book is not available for borrowing.");
            }
        }

        public void ReturnBook()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine("Book successfully returned.");
            }
            else
            {
                Console.WriteLine("The book is already available.");
            }
        }
    }
}
