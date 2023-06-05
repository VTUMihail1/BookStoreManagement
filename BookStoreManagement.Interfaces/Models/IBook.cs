namespace BookStoreManagement.Interfaces.Models
{
    /// <summary>
    /// Represents a book model.
    /// </summary>
    public interface IBook
    {
        /// <summary>
        /// Gets or sets the unique identifier of the book.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Gets or sets the price of the book.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the quantity of the book.
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the description of the book.
        /// </summary>
        public string? Description { get; set; }
    }
}
