namespace BookStoreManagement.Interfaces.Views
{
    /// <summary>
    /// Represents a service for displaying book manipulation-related information in the view.
    /// </summary>
    public interface IBookManipulateViewService
    {
        /// <summary>
        /// Prints the result of adding a book.
        /// </summary>
        /// <param name="isValid">A boolean value indicating if the book addition was valid.</param>
        void PrintAdd(bool isValid);

        /// <summary>
        /// Prints a message indicating the application of a discount to the books.
        /// </summary>
        void PrintDiscount();

        /// <summary>
        /// Prints a message indicating the successful save of the book changes.
        /// </summary>
        void PrintSave();
    }
}