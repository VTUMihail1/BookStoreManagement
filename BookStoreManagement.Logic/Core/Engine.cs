using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Logic.Controllers;
using BookStoreManagement.Logic.Views.Class.Menu;

namespace BookStoreManagement.Logic.Core
{
    public class Engine : IEngine
    {
        private readonly IBookStoreManagementController _bookStoreManagementController;
        private readonly IBooksMainViewService _booksMainViewService;
        private readonly IReader _reader;

        public Engine(IBookStoreManagementController bookStoreManagementController, IBooksMainViewService booksMainViewService, IReader reader)
        {
            _bookStoreManagementController = bookStoreManagementController;
            _booksMainViewService = booksMainViewService;
            _reader = reader;
        }

        public void Run()
        {
            _booksMainViewService.PrintMainView();
            while (true)
            {
                var key = _reader.ReadKey();
                _bookStoreManagementController.Manage(key);

                bool didNotMissClick = key.Key >= ConsoleKey.D1 && key.Key <= ConsoleKey.D6;

                if (didNotMissClick)
                {
                    _booksMainViewService.PrintMainView();
                }
            }
        }
    }
}
