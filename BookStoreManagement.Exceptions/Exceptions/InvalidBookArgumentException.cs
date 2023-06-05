namespace BookStoreManagement.Exceptions.Exceptions
{
    public class InvalidBookArgumentException : Exception
    {
        public InvalidBookArgumentException()
        {

        }

        public InvalidBookArgumentException(string message) : base(message)
        {

        }
    }
}