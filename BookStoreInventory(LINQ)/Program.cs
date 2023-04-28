namespace BookStoreInventory_LINQ_
{
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Book> books = new List<Book>()
            {
                new Book
                {
                    Title = "Crime and Punishment",
                    Author = "Fyodor Dostoyevsky",
                    Price = 190.00m,
                    StockQuantity = 5
                },
                new Book
                {
                    Title = "The Brothers Karamazov",
                    Author = "Fyodor Dostoyevsky",
                    Price = 250.53m,
                    StockQuantity = 0
                },
                new Book
                {
                    Title = "The Idiots",
                    Author = "Fyodor Dostoyevsky",
                    Price = 166.90m,
                    StockQuantity = 5
                },
                new Book
                {
                    Title = "Laws of Human Nature",
                    Author = "Robert Greene",
                    Price = 135.50m,
                    StockQuantity = 0
                }, 
                new Book
                {
                    Title = "48 Laws of Power",
                    Author = "Robert Greene",
                    Price = 180.00m,
                    StockQuantity = 10
                },
                new Book
                {
                    Title = "Art of Seduction",
                    Author = "Robert Greene",
                    Price = 148.00m,
                    StockQuantity = 10
                },
                new Book
                {
                    Title = "1984",
                    Author = "George Orwell",
                    Price = 200.50m,
                    StockQuantity = 7
                },
                new Book
                {
                    Title = "Animal Farm",
                    Author = "George Orwell",
                    Price = 178.40m,
                    StockQuantity = 7
                },
                new Book
                {
                    Title = "The Gulag Archipelago",
                    Author = "A7leksandr Solzhenitsyn",
                    Price = 234.98m,
                    StockQuantity = 4
                }
            };

            Book.ViewAllBooks(books);
            Book.ViewBooksByAuthor(books, "Robert Greene");
            Book.ViewBooksByPrice(books, 120.00m, 190.00m);
            Book.ViewBooksOutOfStock(books);
        }
    }
}