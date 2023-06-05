using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;
using BookStoreManagement.Logic.Controllers;
using BookStoreManagement.Logic.Services;
using BookStoreManagement.Models.Models;
using Moq;
using NUnit.Framework;

namespace BookStoreManagement.UnitTests.Controllers
{
    [TestFixture]
    public class BookManipulateServiceTests
    {
        private IBookManipulateService _bookManipulateService;
        private Mock<IBookFileService> _mockBookFileServices;
        private Mock<ICalculateDiscountService> _mockCalculateDiscountService;
        private Mock<IAddBookFormService> _mockAddBookFormService;


        [SetUp]
        public void Setup()
        {
            _mockBookFileServices = new Mock<IBookFileService>();
            _mockCalculateDiscountService = new Mock<ICalculateDiscountService>();
            _mockAddBookFormService = new Mock<IAddBookFormService>();
            var bookList = new List<IBook>() { new Book() };
            _mockBookFileServices.Setup(x => x.GetAllBooks()).Returns(bookList);
            _bookManipulateService = new BookManipulateService(
                _mockBookFileServices.Object, _mockCalculateDiscountService.Object, _mockAddBookFormService.Object);
        }

        [Test]
        public void AddBook_ValidBook_ReturnsTrue()
        {
            int id = 1;
            var book = new Book();
            _mockAddBookFormService.Setup(x => x.CreateBook(id)).Returns(book);

            var result = _bookManipulateService.AddBook();

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void AddBook_NotValidBook_ReturnsFalse()
        {
            var result = _bookManipulateService.AddBook();

            Assert.That(result, Is.EqualTo(false));
        }
    }
}
