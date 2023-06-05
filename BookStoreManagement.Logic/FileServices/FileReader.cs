using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Models.Models;
using BookStoreManagement.StaticData.StaticData;
using Newtonsoft.Json;
using System.Collections;

namespace BookStoreManagement.Logic.FileServices
{
    public class FileReader : IFileReader
    {
        private readonly IWriter _writer;

        public FileReader(IWriter writer)
        {
            _writer = writer;
        }

        public IList<IBook> Read()
        {
            try
            {
                string path = BookStoreStaticData.GetFilePath;

                string json = File.ReadAllText(path);

                var books = JsonConvert.DeserializeObject<List<Book>>(json);

                IList<IBook> bookList = books.Cast<IBook>().ToList();

                return bookList;
            }
            catch(Exception exception)
            {
                _writer.WriteLine(exception.Message);
                return Enumerable.Empty<IBook>().ToList();
            }
        }
    }
}
