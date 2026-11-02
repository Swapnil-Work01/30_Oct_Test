using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    public class Book
    {
        public static List<Book> Books = new List<Book>();
        public int Id { get; set; }
        public string Title { get; set; }
        private bool _availability { get; set; }

        public Book()
        {

        }
        public Book(int id, string title, bool _availability)
        {
            this.Id = id;
            this.Title = title;
            this._availability = _availability;
        }

        public void Borrow(int id)
        {
            Book book = GetBook(id);
            if(book._availability == false)
            {
                Console.WriteLine("Sorry but this book is not avalable try after some time");
                return;
            }
            else
            {
                Console.WriteLine("Book borrowed successfully");
                book._availability = false;
            }
        }

        public void Return(int id)
        {
            Book book = GetBook(id);
            book._availability = true;
            Console.WriteLine("Book returned successfully");
        }

        public void CreateBook(int id, string title, bool availability)
        {
            Books.Add(new Book(id, title, availability));
        }

        public Book GetBook(int id)
        {
            Book book = null;
            for(int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == id)
                {
                    book = Books[i];
                    break;
                }
            }
            return book;
        }

        public void PrintAllBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Print(Books[i]);
            }
        }

        private void Print(Book book)
        {
            Console.WriteLine($"Book id = {book.Id}");
            Console.WriteLine($"Book title = {book.Title}");
            Console.WriteLine($"Book avalibility status = {book._availability}");
        }
    }
    public class Question18
    {
        public static void Runner()
        {
            Book obj = new Book();

            while (true)
            {
                Console.WriteLine("========== Menu ==========");
                Console.WriteLine("1. Create book");
                Console.WriteLine("2. View books");
                Console.WriteLine("3. Borrow book");
                Console.WriteLine("4. Return book");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Is Book Available (true/false): ");
                        bool availability = Convert.ToBoolean(Console.ReadLine());

                        obj.CreateBook(id, title, availability);

                        Console.WriteLine("Book created successfully.");
                        break;
                        
                    case 2:
                        obj.PrintAllBooks();
                        break;
                    case 3:
                        Console.Write("Enter Book Id to Borrow: ");
                        int borrowId = Convert.ToInt32(Console.ReadLine());

                        obj.Borrow(borrowId);
                        break;
                    case 4:
                        Console.Write("Enter Book Id to Return: ");
                        int returnId = Convert.ToInt32(Console.ReadLine());

                        obj.Return(returnId);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }
    }
}
