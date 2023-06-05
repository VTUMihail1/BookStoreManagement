using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Logic.FileServices
{
    /// <summary>
    /// Represents a file reader service for reading book data from a file.
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// Reads and retrieves book data from a file.
        /// </summary>
        /// <returns>A list of book instances implementing the IBook interface.</returns>
        IList<IBook> Read();
    }
}