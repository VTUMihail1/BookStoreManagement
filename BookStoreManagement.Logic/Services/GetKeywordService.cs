using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.Services
{
    public class GetKeywordService : IGetKeywordService
    {
        private readonly IGetKeywordView _getKeywordMenuService;
        private readonly IReader _reader;

        public GetKeywordService(IGetKeywordView getKeywordMenuService, IReader reader)
        {
            _getKeywordMenuService = getKeywordMenuService;
            _reader = reader;
        }

        public string GetKeyword()
        {
            _getKeywordMenuService.PrintKeyword();

            string keyword = _reader.Read();
            return keyword;
        }
    }
}
