using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Interfaces.Services
{
    /// <summary>
    /// Represents a service for displaying and retrieving book information.
    /// </summary>
    public interface IBookDisplayService
    {
        /// <summary>
        /// Displays all books and returns them as an enumerable collection.
        /// </summary>
        /// <returns>An enumerable collection of book instances implementing the IBook interface.</returns>
        IEnumerable<IBook> DisplayAllBooks();

        /// <summary>
        /// Displays searched books and returns them as an enumerable collection.
        /// </summary>
        /// <returns>An enumerable collection of book instances implementing the IBook interface.</returns>
        IEnumerable<IBook> DisplaySearchedBooks();

        /// <summary>
        /// Calculates and returns the total value of all books.
        /// </summary>
        /// <returns>The total value of all books as a decimal.</returns>
        decimal GetValue();
    }
}