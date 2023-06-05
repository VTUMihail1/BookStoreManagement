namespace BookStoreManagement.Logic.Controllers
{
    /// <summary>
    /// Represents a controller for handling user input related to book manipulation.
    /// </summary>
    public interface IBookManipulateInputController
    {
        /// <summary>
        /// Checks and handles the provided user input.
        /// </summary>
        /// <param name="key">The ConsoleKeyInfo object representing the user input key.</param>
        void CheckInput(ConsoleKeyInfo key);
    }
}