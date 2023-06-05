using BookStoreManagement.Interfaces.HelperInterfaces;

namespace BookStoreManagement.Logic.HelpingClasses
{
    public class Reader : IReader
    {
        public string Read()
        {
            var input = Console.ReadLine();
            return input;
        }

        public ConsoleKeyInfo ReadKey()
        {
            var key = Console.ReadKey();
            return key;
        }
    }
}
