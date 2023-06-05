namespace BookStoreManagement.Interfaces.Services
{
    /// <summary>
    /// Represents a service for manipulating book information.
    /// </summary>
    public interface IBookManipulateService
    {
        /// <summary>
        /// Adds a new book and returns a boolean indicating if the addition was successful.
        /// </summary>
        /// <returns>True if the book was added successfully; otherwise, false.</returns>
        bool AddBook();

        /// <summary>
        /// Applies a discount to the books.
        /// </summary>
        void ApplyDiscount();

        /// <summary>
        /// Saves the changes made to the books.
        /// </summary>
        void Save();
    }
}