using BookStoreManagement.Interfaces.Models;

namespace BookStoreManagement.Interfaces.Factories
{
    /// <summary>
    /// Represents a factory for creating book objects.
    /// </summary>
    public interface IBookFactory
    {
        /// <summary>
        /// Creates a new book instance.
        /// </summary>
        /// <returns>The created book instance.</returns>
        IBook CreateBook();
    }
}
