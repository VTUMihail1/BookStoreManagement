using BookStoreManagement.Interfaces.FileServices;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;

namespace BookStoreManagement.Logic.Services
{
    public class BookManipulateService : IBookManipulateService
    {
        private readonly ICalculateDiscountService _calculateDiscountService;
        private readonly IAddBookFormService _addBookFormService;
        private readonly IBookFileServices _bookFileServices;
        private IList<IBook> _books;

        public BookManipulateService(IBookFileServices bookFileServices, ICalculateDiscountService calculateDiscountService, IAddBookFormService addBookFormService)
        {
            _calculateDiscountService = calculateDiscountService;
            _addBookFormService = addBookFormService;
            _bookFileServices = bookFileServices;
            _books = bookFileServices.GetAllBooks();
        }

        public bool AddBook()
        {
            int id = _books.Max(x => x.Id);
            var book = _addBookFormService.CreateBook(id);

            if(book is not null)
            {
                _books.Add(book);
                return true;
            }
            return false;
        }

        public void ApplyDiscount()
        {
            foreach (var book in _books)
            {
                var discount = _calculateDiscountService.Calculate(book.Price);
                book.Price -= discount;
            }
        }

        public void Save()
        {
            _bookFileServices.SaveAllBooks();
        }
    }
}
