using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace BookStoreInventory_LINQ_
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPrice: {Price}\nStockQuantity: {StockQuantity}";
        }

        public static void ViewAllBooks(IList<Book> books)
        {
            var allBooks = books.Select(x => x);
            foreach (var item in allBooks)
            {
                Console.WriteLine(item);
                Console.WriteLine("============================================================");
            }
        }

        public static void ViewBooksByAuthor(IList<Book> books, string author)
        {
            var booksByAuthor  = books.Where(x => author == x.Author);
            foreach (var item in booksByAuthor)
            {
                Console.WriteLine(item);
                Console.WriteLine("============================================================");
            }
        }

        public static void ViewBooksByPrice(IList<Book> books, decimal minPrice, decimal maxPrice)
        {
            var booksByPrice = books.Where(x => x.Price > minPrice && x.Price < maxPrice);
            foreach (var item in booksByPrice)
            {
                Console.WriteLine(item);
                Console.WriteLine("============================================================");
            }
        }

        public static void ViewBooksOutOfStock(IList<Book> books)
        {
            var booksOutOfStock = books.Where(x => x.StockQuantity == 0);
            foreach (var item in booksOutOfStock)
            {
                Console.WriteLine(item);
                Console.WriteLine("============================================================");
            }
        }

    }
}
