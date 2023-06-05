using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;

namespace BookStoreManagement.Logic.Controllers
{
    public class BookManipulateController : IBookManipulateController
    {
        private readonly IBookManipulateService _bookManipulateServices;
        private readonly IBookManipulateViewService _bookManipulateViewServices;

        public BookManipulateController(IBookManipulateService bookManipulateServices, IBookManipulateViewService bookManipulateViewServices)
        {
            _bookManipulateServices = bookManipulateServices;
            _bookManipulateViewServices = bookManipulateViewServices;
        }

        public void AddBook()
        {
            bool isValid = _bookManipulateServices.AddBook();
            _bookManipulateViewServices.PrintAdd(isValid);
        }

        public void ApplyDiscount()
        {
            _bookManipulateServices.ApplyDiscount();
            _bookManipulateViewServices.PrintDiscount();
        }

        public void Save()
        {
            _bookManipulateServices.Save();
            _bookManipulateViewServices.PrintSave();
        }
    }
}
