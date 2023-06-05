using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.StaticData.StaticData;
using Newtonsoft.Json;

namespace BookStoreManagement.Logic.FileServices
{
    public class FileWriter : IFileWriter
    {
        private readonly IWriter _writer;

        public FileWriter(IWriter writer)
        {
            _writer = writer;
        }

        public void Write(IList<IBook> books)
        {
            try
            {
                string json = JsonConvert.SerializeObject(books, Formatting.Indented);

                string path = BookStoreStaticData.PostFilePath;

                File.WriteAllText(path, json);
            }
            catch(Exception exception)
            {
                _writer.WriteLine(exception.Message);
            }

        }
    }
}
