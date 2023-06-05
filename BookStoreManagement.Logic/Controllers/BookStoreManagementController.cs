using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Logic.HelpingClasses;
using System;
namespace BookStoreManagement.Logic.Controllers
{
    public class BookStoreManagementController : IBookStoreManagementController
    {
        private readonly IBookDisplayInputController _bookDisplayInputController;
        private readonly IBookManipulateInputController _bookManipulateInputController;

        public BookStoreManagementController(IBookManipulateInputController bookManipulateInputController, IBookDisplayInputController bookDisplayInputController)
        {
            _bookManipulateInputController = bookManipulateInputController;
            _bookDisplayInputController = bookDisplayInputController;
        }

        public void Manage(ConsoleKeyInfo key)
        {
            _bookDisplayInputController.CheckInput(key);
            _bookManipulateInputController.CheckInput(key);
        }
    }
}
