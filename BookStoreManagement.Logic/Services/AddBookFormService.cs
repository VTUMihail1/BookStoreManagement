using BookStoreManagement.Interfaces.Factories;
using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.Services
{
    public class AddBookFormService : IAddBookFormService
    {
        private readonly IBookFactory _bookFactory;
        private readonly IReader _reader;
        private readonly IAddBookFormViewService _addBookFormMenuService;

        public AddBookFormService(IBookFactory bookFactory, IReader reader, IAddBookFormViewService addBookFormMenuService)
        {
            _bookFactory = bookFactory;
            _reader = reader;
            _addBookFormMenuService = addBookFormMenuService;
        }

        public IBook CreateBook(int id)
        {
            var book = _bookFactory.CreateBook();
            var type = typeof(IBook);
            var properties = type.GetProperties().Skip(1);
            book.Id = ++id;

            foreach (var property in properties)
            {
                _addBookFormMenuService.PrintProperty(property.Name);
                var value = _reader.Read();

                try
                {
                    var convertedValue = Convert.ChangeType(value, property.PropertyType);
                    property.SetValue(book, convertedValue);

                    bool isNotValid = property is null;

                    if (isNotValid)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception exception)
                {
                    _addBookFormMenuService.PrintPropertyError(property.Name, exception.Message);
                    return null;
                }
            }

            return book;
        }
    }
}
