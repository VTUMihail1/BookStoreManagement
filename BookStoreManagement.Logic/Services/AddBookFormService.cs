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
        private readonly IAddBookFormView _addBookFormView;

        public AddBookFormService(IBookFactory bookFactory, IReader reader, IAddBookFormView addBookFormView)
        {
            _bookFactory = bookFactory;
            _reader = reader;
            _addBookFormView = addBookFormView;
        }

        public IBook CreateBook(int id)
        {
            var book = _bookFactory.CreateBook();
            var type = typeof(IBook);
            var properties = type.GetProperties().Skip(1);
            book.Id = id;

            foreach (var property in properties)
            {
                _addBookFormView.PrintProperty(property.Name);
                var value = _reader.Read();

                try
                {
                    var convertedValue = Convert.ChangeType(value, property.PropertyType);
                    property.SetValue(book, convertedValue);
                }
                catch(Exception exception) 
                {
                    _addBookFormView.PrintPropertyError(property.Name, exception.Message);
                    return null;
                }
            }

            return book;
        }
    }
}
