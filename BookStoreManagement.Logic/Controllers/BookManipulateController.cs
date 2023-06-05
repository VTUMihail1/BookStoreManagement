using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.Controllers
{
    public class BookManipulateController : IBookManipulateController
    {
        private readonly IBookManipulateService _bookManipulateServices;
        private readonly IBookManipulateView _bookManipulateView;

        public BookManipulateController(IBookManipulateService bookManipulateServices, IBookManipulateView bookManipulateView)
        {
            _bookManipulateServices = bookManipulateServices;
            _bookManipulateView = bookManipulateView;
        }

        public void AddBook()
        {
            bool isValid = _bookManipulateServices.AddBook();
            _bookManipulateView.PrintAdd(isValid);
        }

        public void ApplyDiscount()
        {
            _bookManipulateServices.ApplyDiscount();
            _bookManipulateView.PrintDiscount();
        }

        public void Save()
        {
            _bookManipulateServices.Save();
            _bookManipulateView.PrintSave();
        }
    }
}
