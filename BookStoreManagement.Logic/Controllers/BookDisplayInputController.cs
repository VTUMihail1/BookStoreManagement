namespace BookStoreManagement.Logic.Controllers
{
    public class BookDisplayInputController : IBookDisplayInputController
    {
        private readonly IBookDisplayController _bookDisplayController;

        public BookDisplayInputController(IBookDisplayController bookDisplayController)
        {
            _bookDisplayController = bookDisplayController;
        }

        public void CheckInput(ConsoleKeyInfo key)
        {
            bool displayBooks = key.Key == ConsoleKey.D1;
            bool searchBooks = key.Key == ConsoleKey.D2;
            bool calculateValue = key.Key == ConsoleKey.D4;

            if (displayBooks)
            {
                _bookDisplayController.DisplayBooks();
            }
            else if (searchBooks)
            {
                _bookDisplayController.SearchBooks();
            }
            else if (calculateValue)
            {
                _bookDisplayController.ValueOfBooks();
            }
        }
    }
}
