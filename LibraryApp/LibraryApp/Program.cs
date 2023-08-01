using LibraryManagment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System Menu:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Borrow a Book");
                Console.WriteLine("6. Return a Book");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-7): ");
                string choiceStr = Console.ReadLine();

                if (!int.TryParse(choiceStr, out int choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Book newBook = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre
                        };
                        library.AddBook(newBook);
                        Console.WriteLine("Book added successfully!");
                        break;

                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case 4:
                        Console.Write("Enter Book Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        Console.Write("Enter Book ID to borrow: ");
                        int borrowId = int.Parse(Console.ReadLine());
                        var bookToBorrow = library.GetBookById(borrowId);
                        if (bookToBorrow != null)
                        {
                            bookToBorrow.BorrowBook();
                        }
                        else
                        {
                            Console.WriteLine("Book not found with the given ID.");
                        }
                        break;

                    case 6:
                        Console.Write("Enter Book ID to return: ");
                        int returnId = int.Parse(Console.ReadLine());
                        var bookToReturn = library.GetBookById(returnId);
                        if (bookToReturn != null)
                        {
                            bookToReturn.ReturnBook();
                        }
                        else
                        {
                            Console.WriteLine("Book not found with the given ID.");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Exiting Library Management System...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
