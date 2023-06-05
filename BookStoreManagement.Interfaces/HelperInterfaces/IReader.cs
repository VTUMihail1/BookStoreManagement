namespace BookStoreManagement.Interfaces.HelperInterfaces
{
    /// <summary>
    /// Represents a reader service for reading user input.
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Reads a line of input from the user.
        /// </summary>
        /// <returns>The string entered by the user.</returns>
        string Read();

        /// <summary>
        /// Reads a key press from the user.
        /// </summary>
        /// <returns>The ConsoleKeyInfo object representing the key pressed by the user.</returns>
        ConsoleKeyInfo ReadKey();
    }
}