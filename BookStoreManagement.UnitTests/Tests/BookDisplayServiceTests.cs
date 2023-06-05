using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Logic.Services;
using BookStoreManagement.Models.Models;
using Moq;
using NUnit.Framework;

namespace BookStoreManagement.UnitTests.Tests
{
    [TestFixture]
    public class BookDisplayServiceTests
    {
        private IBookDisplayService _bookDisplayService;
        private Mock<IBookFileService> _mockBookFileService;
        private Mock<IGetKeywordService> _mockGetKeywordService;

        [SetUp]
        public void Setup()
        {
            var bookList = new List<IBook>() { new Book() { Author = "Vazov", Title = "Pod igoto" } };
            _mockGetKeywordService = new Mock<IGetKeywordService>();
            _mockBookFileService = new Mock<IBookFileService>();
            _mockBookFileService.Setup(x => x.GetAllBooks()).Returns(bookList);
            _bookDisplayService = new BookDisplayService(_mockBookFileService.Object, _mockGetKeywordService.Object);
        }

        [Test]
        public void DisplaySearchedBooks_AuthorMatchesTheKeyword_ReturnsSearchedBooks()
        {
            _mockGetKeywordService.Setup(x => x.GetKeyword()).Returns("Vazov");

            var list = _bookDisplayService.DisplaySearchedBooks();

            Assert.That(list.Count(), Is.EqualTo(1));
        }

        [Test]
        public void DisplaySearchedBooks_AuthorDoesNotMatchesTheKeyword_ReturnsEmptyList()
        {
            _mockGetKeywordService.Setup(x => x.GetKeyword()).Returns("Vazovv");

            var list = _bookDisplayService.DisplaySearchedBooks();

            Assert.That(list.Count(), Is.EqualTo(0));
        }

        [Test]
        public void DisplaySearchedBooks_TitleMatchesTheKeyword_ReturnsSearchedBooks()
        {
            _mockGetKeywordService.Setup(x => x.GetKeyword()).Returns("Pod igoto");

            var list = _bookDisplayService.DisplaySearchedBooks();

            Assert.That(list.Count(), Is.EqualTo(1));
        }

        [Test]
        public void DisplaySearchedBooks_TitleDoesNotMatchesTheKeyword_ReturnsEmptyList()
        {
            _mockGetKeywordService.Setup(x => x.GetKeyword()).Returns("Pod igotoo");

            var list = _bookDisplayService.DisplaySearchedBooks();

            Assert.That(list.Count, Is.EqualTo(0));
        }
    }
}
