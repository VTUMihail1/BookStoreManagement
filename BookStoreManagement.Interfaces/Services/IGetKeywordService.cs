namespace BookStoreManagement.Interfaces.Services
{
    /// <summary>
    /// Represents a service for retrieving a keyword.
    /// </summary>
    public interface IGetKeywordService
    {
        /// <summary>
        /// Retrieves a keyword.
        /// </summary>
        /// <returns>The retrieved keyword as a string.</returns>
        string GetKeyword();
    }
}