using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Logic.HelpingClasses;
using BookStoreManagement.Logic.Views.Class.Menu;
using System;
namespace BookStoreManagement.Logic.Controllers
{
    public class BookStoreManagementController : IBookStoreManagementController
    {
        private readonly IBookDisplayInputController _bookDisplayInputController;
        private readonly IBookManipulateInputController _bookManipulateInputController;
        private readonly IBooksMainView _booksMainViewService;

        public BookStoreManagementController(IBookManipulateInputController bookManipulateInputController, IBookDisplayInputController bookDisplayInputController, IBooksMainView booksMainViewService)
        {
            _bookManipulateInputController = bookManipulateInputController;
            _bookDisplayInputController = bookDisplayInputController;
            _booksMainViewService = booksMainViewService;
        }

        public void Manage(ConsoleKeyInfo key)
        {
            _bookDisplayInputController.CheckInput(key);
            _bookManipulateInputController.CheckInput(key);

            bool didNotMissClick = key.Key >= ConsoleKey.D1 && key.Key <= ConsoleKey.D6;

            if (didNotMissClick)
            {
                _booksMainViewService.PrintMainView();
            }
        }
    }
}
