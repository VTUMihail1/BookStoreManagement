namespace BookStoreManagement.Logic.Controllers
{
    /// <summary>
    /// Represents a controller for displaying books.
    /// </summary>
    public interface IBookDisplayController
    {
        /// <summary>
        /// Displays the list of books.
        /// </summary>
        void DisplayBooks();

        /// <summary>
        /// Searches for books based on specified criteria.
        /// </summary>
        void SearchBooks();

        /// <summary>
        /// Calculates and displays the total value of the books.
        /// </summary>
        void ValueOfBooks();
    }
}