using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.MenuServices
{
    public class AddBookFormViewService : IAddBookFormViewService
    {
        private readonly IWriter _writer;
        private readonly ICleaner _cleaner;

        public AddBookFormViewService(IWriter writer, ICleaner cleaner)
        {
            _writer = writer;
            _cleaner = cleaner;
        }
        public void PrintPropertyError(string property, string exception)
        {
            var message = $"Error setting value for {property}: {exception}";

            _writer.WriteLine(message);
        }

        public void PrintProperty(string property)
        {
            var message = $"Enter value for {property}:";

            _cleaner.Clear();
            _writer.WriteLine(message);
        }
    }
}
