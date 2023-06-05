using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Interfaces.Services
{
    /// <summary>
    /// Represents a service for creating book instances to add to a book form.
    /// </summary>
    public interface IAddBookFormService
    {
        /// <summary>
        /// Creates a new book instance with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the book.</param>
        /// <returns>An instance of a book implementing the IBook interface.</returns>
        IBook CreateBook(int id);
    }
}
