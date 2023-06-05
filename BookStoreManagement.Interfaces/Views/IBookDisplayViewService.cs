using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Interfaces.Views
{
    /// <summary>
    /// Represents a service for displaying book-related information in the view.
    /// </summary>
    public interface IBookDisplayViewService
    {
        /// <summary>
        /// Prints the details of a collection of books.
        /// </summary>
        /// <param name="books">The collection of books to print.</param>
        void PrintBooks(IEnumerable<IBook> books);

        /// <summary>
        /// Prints the total value of the books.
        /// </summary>
        /// <param name="value">The total value of the books.</param>
        void PrintValue(decimal value);
    }
}