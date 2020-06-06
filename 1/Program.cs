using System;

namespace _1
{
    public class Book
    {
        internal string AuthorName;
        internal string Title;
        public string CodeOfBook;
        public int PagesCount;
        public bool Collectable;

        public Book(string CodeOfBook, int PagesCount, bool Collectable)
        {
            AuthorName = "Неизвестно";
            Title = "Неизвестно";
            this.CodeOfBook = CodeOfBook;
            this.PagesCount = PagesCount;
            this.Collectable = Collectable;
        }

        public Book(string AuthorName, string Title, string CodeOfBook, int PagesCount, bool Collectable)
        {
            this.AuthorName = AuthorName;
            this.Title = Title;
            this.CodeOfBook = CodeOfBook;
            this.PagesCount = PagesCount;
            this.Collectable = Collectable;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Book Book1 = new Book("365-8958-4783", 248, true);
            Book Book2 = new Book("Владимир Маяковский", "Я сам", "978-5-4453-0641-2", 224, false);

            bool isCollectable1 = Book1.Collectable;
            bool isCollectable2 = Book2.Collectable;

            string collectable1;
            string collectable2;

            if (isCollectable1)
            {
                collectable1 = "Коллекционное";
            }
            else
            {
                collectable1 = "Не коллекционное";
            }

            if (isCollectable2)
            {
                collectable2 = "Коллекционное";
            }
            else
            {
                collectable2 = "Не коллекционное";
            }

            Console.WriteLine($"{Book2.AuthorName} \n" +
                              $"{Book2.Title} \n" +
                              $"{Book2.CodeOfBook} \n" +
                              $"{Book2.PagesCount} \n" +
                              $"{collectable2}\n");

            Console.WriteLine($"{Book1.AuthorName} \n" +
                              $"{Book1.Title} \n" +
                              $"{Book1.CodeOfBook} \n" +
                              $"{Book1.PagesCount} \n" +
                              $"{collectable1}");


        }
    }
}
