using HighTask.Entities;

namespace HighTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Book1", "Author1", 20);
            Book book2 = new Book("Book2", "Author2", 30);
            Book book3 = new Book("Book3", "Author3", 40);

            Library library = new Library(3);
            try
            {
                library.AddBook(book1);
                library.AddBook(book2);
                library.AddBook(book3);
                foreach (var item in library.GetAllBooks())
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("======================");
                foreach (var item in library.FilterByPageCount(10,45))
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("======================");
                library.EditBookName(2, "Tehmasib");
                foreach (var item in library.GetAllBooks())
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
