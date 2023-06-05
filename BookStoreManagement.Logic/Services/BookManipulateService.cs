using BookStoreManagement.Interfaces.FileServices;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;

namespace BookStoreManagement.Logic.Services
{
    public class BookManipulateService : IBookManipulateService
    {
        private readonly ICalculateDiscountService _calculateDiscountService;
        private readonly IAddBookFormService _addBookFormService;
        private readonly IBookFileService _bookFileServices;
        private readonly IList<IBook> _books;

        public BookManipulateService(IBookFileService bookFileService, ICalculateDiscountService calculateDiscountService, IAddBookFormService addBookFormService)
        {
            _calculateDiscountService = calculateDiscountService;
            _addBookFormService = addBookFormService;
            _bookFileServices = bookFileService;
            _books = bookFileService.GetAllBooks();
        }

        public bool AddBook()
        {
            var id = _books.Max(x => x.Id);
            var newId = ++id;
            var book = _addBookFormService.CreateBook(newId);

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
