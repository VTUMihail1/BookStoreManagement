using BookStoreManagement.Logic.Controllers;
using Moq;
using NUnit.Framework;

namespace BookStoreManagement.UnitTests.Tests
{
    public class BookDisplayInputControllerTests
    {
        private IBookDisplayInputController _bookDisplayInputController;
        private Mock<IBookDisplayController> _mockBookDisplayController;

        [SetUp]
        public void SetUp()
        {
            _mockBookDisplayController = new Mock<IBookDisplayController>();
            _bookDisplayInputController = new BookDisplayInputController(_mockBookDisplayController.Object);
        }

        [Test]
        public void Manage_InputIsKeyOne_DisplaysAllBooks()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo('1', ConsoleKey.D1, false, false, false);
            _bookDisplayInputController.CheckInput(keyInfo);

            _mockBookDisplayController.Verify(x => x.DisplayBooks(), Times.Exactly(1));
        }

        [Test]
        public void Manage_InputIsKeyTwo_SearchBooks()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo('2', ConsoleKey.D2, false, false, false);
            _bookDisplayInputController.CheckInput(keyInfo);

            _mockBookDisplayController.Verify(x => x.SearchBooks(), Times.Exactly(1));
        }

        [Test]
        public void Manage_InputIsKeyFour_CalculatesTheValue()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo('4', ConsoleKey.D4, false, false, false);
            _bookDisplayInputController.CheckInput(keyInfo);

            _mockBookDisplayController.Verify(x => x.ValueOfBooks(), Times.Exactly(1));
        }
    }
}
