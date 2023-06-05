namespace BookStoreManagement.Logic.Controllers
{
    /// <summary>
    /// Represents a controller for managing the bookstore operations.
    /// </summary>
    public interface IBookStoreManagementController
    {
        /// <summary>
        /// Manages the operations based on the provided user input key.
        /// </summary>
        /// <param name="key">The ConsoleKeyInfo object representing the user input key.</param>
        void Manage(ConsoleKeyInfo key);
    }
}