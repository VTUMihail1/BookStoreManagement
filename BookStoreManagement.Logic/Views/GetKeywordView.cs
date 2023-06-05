using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Views;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.MenuServices
{
    public class GetKeywordView : IGetKeywordView
    {
        private readonly IWriter _writer;
        private readonly ICleaner _cleaner;

        public GetKeywordView(IWriter writer, ICleaner cleaner)
        {
            _writer = writer;
            _cleaner = cleaner;
        }

        public void PrintKeyword()
        {
            var message = BookStoreStaticData.SearchMessage;
            _cleaner.Clear();
            _writer.Write(message);
        }
    }
}
