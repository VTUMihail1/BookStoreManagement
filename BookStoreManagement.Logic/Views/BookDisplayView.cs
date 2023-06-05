using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Views;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.MenuServices
{
    public class BookDisplayView : IBookDisplayView
    {
        private readonly IWriter _writer;
        private readonly ICleaner _cleaner;

        public BookDisplayView(IWriter writer, ICleaner cleaner)
        {
            _writer = writer;
            _cleaner = cleaner;
        }

        public void PrintBooks(IEnumerable<IBook> books)
        {
            string top = BookStoreStaticData.TableHeader;
            _cleaner.Clear();
            _writer.WriteLine(top);

            foreach (var book in books)
            {
                string message = string.Format("{0,-5} | {1,-50} | {2,-50} | {3,-8:c} | {4,-8} | {5,-100}",
                    book.Id, book.Title, book.Author, book.Price, book.Quantity, book.Description);
                _writer.WriteLine(message);
            }
        }

        public void PrintValue(decimal value)
        {
            string message = $"Total Bookstore Value: ${value}\n";
            _cleaner.Clear();
            _writer.WriteLine(message);
        }
    }
}
