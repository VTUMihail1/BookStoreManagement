using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Interfaces.FileServices
{
    /// <summary>
    /// Represents a service for managing book data in a file.
    /// </summary>
    public interface IBookFileService
    {
        /// <summary>
        /// Retrieves all books from the file.
        /// </summary>
        /// <returns>A list of book instances implementing the IBook interface.</returns>
        IList<IBook> GetAllBooks();

        /// <summary>
        /// Saves all books to the file.
        /// </summary>
        void SaveAllBooks();
    }
}
