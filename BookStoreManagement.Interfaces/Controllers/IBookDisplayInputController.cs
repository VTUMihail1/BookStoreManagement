namespace BookStoreManagement.Logic.Controllers
{
    /// <summary>
    /// Represents a controller for handling user input.
    /// </summary>
    public interface IBookDisplayInputController
    {
        /// <summary>
        /// Checks and handles the provided user input.
        /// </summary>
        /// <param name="key">The ConsoleKeyInfo object representing the user input key.</param>
        void CheckInput(ConsoleKeyInfo key);
    }
}