using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.Controllers
{
    public class BookDisplayController : IBookDisplayController
    {
        private readonly IBookDisplayService _bookDisplayServices;
        private readonly IBookDisplayViewService _bookDisplayViewServices;

        public BookDisplayController(IBookDisplayService bookDisplayServices, IBookDisplayViewService bookDisplayViewServices)
        {
            _bookDisplayServices = bookDisplayServices;
            _bookDisplayViewServices = bookDisplayViewServices;
        }

        public void DisplayBooks()
        {
            var books = _bookDisplayServices.DisplayAllBooks();
            _bookDisplayViewServices.PrintBooks(books);
        }

        public void SearchBooks()
        {
            var books = _bookDisplayServices.DisplaySearchedBooks();
            _bookDisplayViewServices.PrintBooks(books);
        }

        public void ValueOfBooks()
        {
            var value = _bookDisplayServices.GetValue();
            _bookDisplayViewServices.PrintValue(value);
        }
    }
}
