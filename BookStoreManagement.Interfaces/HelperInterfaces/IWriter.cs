namespace BookStoreManagement.Interfaces.HelperInterfaces
{
    /// <summary>
    /// Represents a writer service for outputting messages to the console.
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Writes the specified message to the output.
        /// </summary>
        /// <param name="message">The message to be written.</param>
        void Write(string message);

        /// <summary>
        /// Writes the specified message followed by a line break to the output.
        /// </summary>
        /// <param name="message">The message to be written.</param>
        void WriteLine(string message);
    }
}