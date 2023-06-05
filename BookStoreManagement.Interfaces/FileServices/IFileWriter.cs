using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Logic.FileServices
{
    /// <summary>
    /// Represents a file writer service for writing book data to a file.
    /// </summary>
    public interface IFileWriter
    {
        /// <summary>
        /// Writes the provided list of book instances to a file.
        /// </summary>
        /// <param name="books">The list of book instances to be written.</param>
        void Write(IList<IBook> books);
    }
}