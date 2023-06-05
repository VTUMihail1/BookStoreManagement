using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.Views.Class.Menu
{
    public class BooksMainViewService : IBooksMainViewService
    {
        private readonly IWriter _writer;

        public BooksMainViewService(IWriter writer)
        {
            _writer = writer;
        }
        public void PrintMainView()
        {
            string message = BookStoreStaticData.MainMenu;

            _writer.WriteLine(message);
        }
    }
}
