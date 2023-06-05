using BookStoreManagement.Interfaces.FileServices;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Logic.FileServices;

namespace BookStoreManagement.Logic.Services
{
    public class BookFileServices : IBookFileService
    {
        private readonly IFileReader _fileReader;
        private readonly IFileWriter _fileWriter;
        private IList<IBook> _books;

        public BookFileServices(IFileReader fileReader, IFileWriter fileWriter)
        {
            _fileReader = fileReader;
            _fileWriter = fileWriter;
        }

        public IList<IBook> GetAllBooks()
        {
            if(_books is null)
            {
                _books = _fileReader.Read();
            }

            return _books;
        }

        public void SaveAllBooks()
        {
            _fileWriter.Write(_books);
        }
    }
}
