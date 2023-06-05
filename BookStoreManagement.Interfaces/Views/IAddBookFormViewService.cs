namespace BookStoreManagement.Interfaces.Views
{
    /// <summary>
    /// Represents a service for displaying and printing book form-related information.
    /// </summary>
    public interface IAddBookFormViewService
    {
        /// <summary>
        /// Prints the name of a property.
        /// </summary>
        /// <param name="property">The name of the property to print.</param>
        void PrintProperty(string property);

        /// <summary>
        /// Prints an error message associated with a property.
        /// </summary>
        /// <param name="property">The name of the property.</param>
        /// <param name="exception">The exception message associated with the property.</param>
        void PrintPropertyError(string property, string exception);
    }
}