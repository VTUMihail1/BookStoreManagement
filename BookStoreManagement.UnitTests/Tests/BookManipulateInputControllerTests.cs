using BookStoreManagement.Logic.Controllers;
using Moq;
using NUnit.Framework;

namespace BookStoreManagement.UnitTests.Services
{
    [TestFixture]
    public class BookManipulateInputControllerTests
    {
        private IBookManipulateInputController _bookManipulateInputController;
        private Mock<IBookManipulateController> _mockBookManipulateController;

        [SetUp]
        public void SetUp()
        {
            _bookManipulateInputController = new BookManipulateInputController(_mockBookManipulateController.Object);
        }

        [Test]
        public void Manage_InputIsKeyThree_AddsABook()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo('3', ConsoleKey.D3, false, false, false);
            _bookManipulateInputController.CheckInput(keyInfo);

            _mockBookManipulateController.Verify(x => x.AddBook(), Times.Exactly(1));
        }

        [Test]
        public void Manage_InputIsKeyFive_AppliesDiscount()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo('5', ConsoleKey.D5, false, false, false);
            _bookManipulateInputController.CheckInput(keyInfo);

            _mockBookManipulateController.Verify(x => x.ApplyDiscount(), Times.Exactly(1));
        }

        [Test]
        public void Manage_InputIsKeySix_SavesTheFile()
        {
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo('6', ConsoleKey.D6, false, false, false);
            _bookManipulateInputController.CheckInput(keyInfo);

            _mockBookManipulateController.Verify(x => x.Save(), Times.Exactly(1));
        }
    }
}
