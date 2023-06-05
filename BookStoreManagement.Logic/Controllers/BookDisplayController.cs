using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.Controllers
{
    public class BookDisplayController : IBookDisplayController
    {
        private readonly IBookDisplayService _bookDisplayServices;
        private readonly IBookDisplayView _bookDisplayView;

        public BookDisplayController(IBookDisplayService bookDisplayServices, IBookDisplayView bookDisplayView)
        {
            _bookDisplayServices = bookDisplayServices;
            _bookDisplayView = bookDisplayView;
        }

        public void DisplayBooks()
        {
            var books = _bookDisplayServices.DisplayAllBooks();
            _bookDisplayView.PrintBooks(books);
        }

        public void SearchBooks()
        {
            var books = _bookDisplayServices.DisplaySearchedBooks();
            _bookDisplayView.PrintBooks(books);
        }

        public void ValueOfBooks()
        {
            var value = _bookDisplayServices.GetValue();
            _bookDisplayView.PrintValue(value);
        }
    }
}
