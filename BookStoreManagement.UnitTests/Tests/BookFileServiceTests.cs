using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Logic.FileServices;
using BookStoreManagement.Logic.Services;
using BookStoreManagement.Models.Models;
using Moq;
using NUnit.Framework;

namespace BookStoreManagement.UnitTests.Tests
{
    [TestFixture]
    public class BookFileServiceTests
    {
        private IBookFileService _bookFileService;
        private Mock<IFileReader> _mockFileReader;
        private Mock<IFileWriter> _mockFileWriter;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileWriter = new Mock<IFileWriter>();
            var bookList = new List<IBook>() { new Book() };
            _mockFileReader.Setup(x => x.Read()).Returns(bookList);
            _bookFileService = new BookFileService(_mockFileReader.Object, _mockFileWriter.Object);
        }

        [Test]
        public void GetAllBooks_ListIsNull_CreatesTheList()
        {
            var list = _bookFileService.GetAllBooks();

            Assert.That(list.Count, Is.EqualTo(1));
        }
    }
}
