namespace BookStoreManagement.Logic.Controllers
{
    /// <summary>
    /// Represents a controller for manipulating books.
    /// </summary>
    public interface IBookManipulateController
    {
        /// <summary>
        /// Adds a new book to the collection.
        /// </summary>
        void AddBook();

        /// <summary>
        /// Applies a discount to the prices of the books.
        /// </summary>
        void ApplyDiscount();

        /// <summary>
        /// Saves the changes made to the books.
        /// </summary>
        void Save();
    }
}