namespace BookStoreManagement.Logic.Controllers
{
    public class BookManipulateInputController : IBookManipulateInputController
    {
        private readonly IBookManipulateController _bookManipulateController;

        public BookManipulateInputController(IBookManipulateController bookManipulateController)
        {
            _bookManipulateController = bookManipulateController;
        }

        public void CheckInput(ConsoleKeyInfo key)
        {
            bool addBook = key.Key == ConsoleKey.D3;
            bool applyDiscount = key.Key == ConsoleKey.D5;
            bool save = key.Key == ConsoleKey.D6;

            if (addBook)
            {
                _bookManipulateController.AddBook();
            }
            else if (applyDiscount)
            {
                _bookManipulateController.ApplyDiscount();
            }
            else if (save)
            {
                _bookManipulateController.Save();
            }
        }
    }
}
