using BookStoreManagement.Interfaces.HelperInterfaces;

namespace BookStoreManagement.Logic.HelpingClasses
{
    public class Writer : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
