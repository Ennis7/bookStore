using System;

namespace bookStore
{
    class Book
    {
        private int _Id;  
        private string _Title;  
        private string _Author;  

     //Default Constructor
        public Book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

     //Parameterized Constructor
        public Book(int i, string Title, string Author)
        {
            _Id = i;
            _Title =Title;
            _Author =Author;
        }
     //Get Methods
        
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetAuthor()
        {
            return _Author;
        }
     //Set Methods
        public void SetId(int identification)
        {
            _Id = identification;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }

    class myStore
    {
        static void Main(string[] args)
        {
         //book object w/ default constructor
            Book book1 = new Book();
            book1.SetId(1);
            book1.SetTitle("Midnight Library");
            book1.SetAuthor("Matt Haig");

         //book object w/ default constructor (prompt user)
            Book book2 = new Book();
            Console.WriteLine("Please enter the ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title of the book:");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the author of the book:");
            book2.SetAuthor(Console.ReadLine());

         //book object w/ parameterized constructor
            Book book3 = new Book(3, "Project Hail Mary", "Andy Weir");

         //book object w/ parameterized constructor (prompt user)
            Console.WriteLine("Please enter the ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title of the book: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the author of the book: ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempID, tempTitle, tempAuthor);

         //Call books
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
            
        }
        //Name the method displayBooks

        static void displayBooks(Book book)
        {
            Console.WriteLine("Here's the book's information");
            Console.WriteLine($"Book ID: {book.GetId()}");
            Console.WriteLine($"Book Title: {book.GetTitle()}");
            Console.WriteLine($"Book Author: {book.GetAuthor()}");
            Console.ReadKey();
        }
    }
}
