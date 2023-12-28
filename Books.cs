using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassAndObject
{
    internal class Book
    {
        public int bookId;
        public string BookName;
        public string language;
        public double price;
        public string Author;
        public string Publisher;
    }
    class BookRepository
    {
        public Book[] books = new Book[5];
        public int index = 0;
        public void AddBook(Book book) // to add books
        {
            if (index <= books.Length)
            {
                books[index] = book;
                index++;
                Console.WriteLine("Book Added Sucessfully");
            }
            else
            {
                Console.WriteLine("Can't add book. Its full..!!");
            }
        }
        public Book[] GetBookByName(string bookName) // GET BOOKS BY NAME
        {
            Book[] bookNames = new Book[books.Length];
            int index = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.BookName == bookName)
                    {
                        bookNames[index] = book;
                        index++;
                    }
                }
            }
            return bookNames;
        }
        public Book[] GetBookByAuthor(string author) // GET BOOKS BY Author
        {
            Book[] authors = new Book[books.Length];
            int index = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Author == author)
                    {
                        authors[index] = book;
                        index++;
                    }
                }
            }
            return authors;
        }
        public Book[] GetBookByPublisher(string publisher) // GET BOOKS BY publisher
        {
            Book[] publishers = new Book[books.Length];
            int index = 0;
            foreach (Book book in books)
            {
                if (book != null)
                {
                    if (book.Publisher == publisher)
                    {
                        publishers[index] = book;
                        index++;
                    }
                }
            }
            return publishers;
        }
        public Book[] GetAllBooks()
        {
            return books;
        }
        public Book GetBookById(int id) //get book details with id
        {
            foreach (Book book in books)
            {
                if ((book != null))
                {
                    if (book.bookId == id)
                    {
                        return book;
                    }
                }

            }
            return null;
        }
        class Book_Main
        {
            static void Main()
            {
                BookRepository bookRepository = new BookRepository();
                do
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Add a Book");
                    Console.WriteLine("2. Get Book By Id:");
                    Console.WriteLine("3. Get Book By Book Name");
                    Console.WriteLine("4. Get Book By Author:");
                    Console.WriteLine("5. Get Book By Publisher:");
                    Console.WriteLine("6. Get all Books:");
                    Console.WriteLine("Enter Your Choice:");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Book book = new Book();
                            Console.WriteLine("Enter Book Name:");
                            book.BookName = Console.ReadLine();
                            Console.WriteLine("Enter Author Name:");
                            book.Author = Console.ReadLine();
                            Console.WriteLine("Enter Publisher Name:");
                            book.Publisher = Console.ReadLine();
                            Console.WriteLine("Enter Price of book:");
                            book.price = double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Language:");
                            book.language = Console.ReadLine();
                            book.bookId = new Random().Next();
                            bookRepository.AddBook(book);
                            break;
                        case 2: //get book by id
                            Console.WriteLine("Enter Book Id:");
                            int id = int.Parse(Console.ReadLine());
                            Book foundBook = bookRepository.GetBookById(id);
                            if (foundBook != null)
                            {
                                Console.WriteLine($"Id:{foundBook.bookId} Book Name:{foundBook.BookName} Author:{foundBook.Author} language:{foundBook.language} Price: {foundBook.price} Publisher: {foundBook.Publisher} Language: {foundBook.language}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Id");
                            }
                            break;
                        case 3: //get book by name
                            Console.WriteLine("Enter Book Name:");
                            string bookName = Console.ReadLine();
                            Book[] booksByName = bookRepository.GetBookByName(bookName);
                            if (booksByName.Length > 0)
                            {
                                Console.WriteLine("Books Found:");
                                foreach (var bk in booksByName)
                                {
                                    if (bk != null)
                                    {
                                        Console.WriteLine($"Id:{bk.bookId} Name:{bk.BookName} Author:{bk.Author} language:{bk.language} Price: {bk.price}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Books Found by that Name");
                            }
                            break;
                        case 4: //get book by author
                            Console.WriteLine("Enter Author Name:");
                            string author = Console.ReadLine();
                            Book[] booksByAuthor = bookRepository.GetBookByAuthor(author);
                            if (booksByAuthor.Length > 0)
                            {
                                Console.WriteLine("Books Found:");
                                foreach (var bk in booksByAuthor)
                                {
                                    if (bk != null)
                                    {
                                        Console.WriteLine($"Id:{bk.bookId} Name:{bk.BookName} Author:{bk.Author} language:{bk.language} Price: {bk.price}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Books Found by that Author");
                            }
                            break;
                        case 5: //get book by publisher
                            Console.WriteLine("Enter Publisher Name:");
                            string publisher = Console.ReadLine();
                            Book[] booksByPublisher = bookRepository.GetBookByPublisher(publisher);
                            if (booksByPublisher.Length > 0)
                            {
                                Console.WriteLine("Books Found:");
                                foreach (var bk in booksByPublisher)
                                {
                                    if (bk != null)
                                    {
                                        Console.WriteLine($"Id:{bk.bookId} Name:{bk.BookName} Author:{bk.Author} language:{bk.language} Price: {bk.price}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Books Found by that Publisher");
                            }
                            break;
                        case 6: //get all books
                            Book[] allBooks = bookRepository.GetAllBooks();
                            if (allBooks.Length > 0)
                            {
                                Console.WriteLine("All Books:");
                                foreach (var bk in allBooks)
                                {
                                    if (bk != null)
                                    {
                                        Console.WriteLine($"Id:{bk.bookId} Name:{bk.BookName} Author:{bk.Author} language:{bk.language} Price: {bk.price}");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No Books Found");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                } while (true);
            }
        }
    }
}