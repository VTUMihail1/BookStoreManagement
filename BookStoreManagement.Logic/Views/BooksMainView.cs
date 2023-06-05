using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.Views.Class.Menu
{
    public class BooksMainView : IBooksMainView
    {
        private readonly IWriter _writer;

        public BooksMainView(IWriter writer)
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
