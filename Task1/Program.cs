namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Enter title of the book: ");
            book.Title = Console.ReadLine();
            Console.WriteLine("Enter author of the book: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Enter isbn number: ");
            book.Isbn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year of publishing: ");
            book.PublishYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of pages: ");
            book.NumberOfPages = int.Parse(Console.ReadLine());

            book.GetBookDetails();
        }
    }
}