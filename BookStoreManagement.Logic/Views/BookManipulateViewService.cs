using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Views;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.MenuServices
{
    public class BookManipulateViewService : IBookManipulateViewService
    {
        private readonly IWriter _writer;
        private readonly ICleaner _cleaner;

        public BookManipulateViewService(IWriter writer, ICleaner cleaner)
        {
            _writer = writer;
            _cleaner = cleaner;
        }

        public void PrintAdd(bool isValid)
        {
            string message;

            if(isValid)
            {
                message = BookStoreStaticData.AddedSuccesfullyMessage;
            }
            else
            {
                message = BookStoreStaticData.AddedUnsuccesfullyMessage;
            }

            _cleaner.Clear();
            _writer.WriteLine(message);
        }

        public void PrintSave()
        {
            var message = BookStoreStaticData.SaveFileMessage;
            _cleaner.Clear();
            _writer.WriteLine(message);
        }

        public void PrintDiscount()
        {
            var message = BookStoreStaticData.DiscountMessage;

            _cleaner.Clear();
            _writer.WriteLine(message);
        }
    }
}
