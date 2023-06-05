using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Interfaces.Services
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
        /// Add a book to the collection
        /// </summary>
        /// <param name="book">A book object that will be added to the collection</param>
        void AddBook(IBook book);

        /// <summary>
        /// Saves all books to the file.
        /// </summary>
        void SaveAllBooks();
    }
}
