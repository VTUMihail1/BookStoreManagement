using BookStoreManagement.Interfaces.HelperInterfaces;

namespace BookStoreManagement.Logic.HelpingClasses
{
    public class Cleaner : ICleaner
    {
        public void Clear()
        {
            Console.Clear();
        }
    }
}
