using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Views;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.MenuServices
{
    public class BookManipulateView : IBookManipulateView
    {
        private readonly IWriter _writer;
        private readonly ICleaner _cleaner;

        public BookManipulateView(IWriter writer, ICleaner cleaner)
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
                _cleaner.Clear();
            }
            else
            {
                message = BookStoreStaticData.AddedUnsuccesfullyMessage;
            }
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
