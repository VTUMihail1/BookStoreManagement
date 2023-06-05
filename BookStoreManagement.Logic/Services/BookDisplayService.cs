﻿using BookStoreManagement.Interfaces.FileServices;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.StaticData.StaticData;

namespace BookStoreManagement.Logic.Services
{
    public class BookDisplayService : IBookDisplayService
    {
        public readonly IList<IBook> _books;
        private readonly IGetKeywordService _getKeywordService;

        public BookDisplayService(IBookFileServices getAllBooksList, IGetKeywordService getKeywordService)
        {
            _books = getAllBooksList.GetAllBooks();
            _getKeywordService = getKeywordService;
        }

        public IEnumerable<IBook> DisplayAllBooks()
        {
            return _books;
        }

        public IEnumerable<IBook> DisplaySearchedBooks()
        {
            string searchKeyword = _getKeywordService.GetKeyword();

            var searchedBooks = _books.Where(x =>
            x.Title.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= BookStoreStaticData.LowestPossibleIndex ||
            x.Author.IndexOf(searchKeyword, StringComparison.OrdinalIgnoreCase) >= BookStoreStaticData.LowestPossibleIndex);

            return searchedBooks;
        }

        public decimal GetValue()
        {
            var value = _books.Sum(x => x.Price * x.Quantity);

            return value;
        }
    }
}