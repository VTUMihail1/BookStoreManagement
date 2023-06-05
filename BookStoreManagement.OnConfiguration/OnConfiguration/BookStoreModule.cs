using BookStoreManagement.Interfaces.Factories;
using BookStoreManagement.Interfaces.FileServices;
using BookStoreManagement.Interfaces.HelperInterfaces;
using BookStoreManagement.Interfaces.Models;
using BookStoreManagement.Interfaces.Services;
using BookStoreManagement.Interfaces.Views;
using BookStoreManagement.Logic.Controllers;
using BookStoreManagement.Logic.Core;
using BookStoreManagement.Logic.FileServices;
using BookStoreManagement.Logic.HelpingClasses;
using BookStoreManagement.Logic.MenuServices;
using BookStoreManagement.Logic.Services;
using BookStoreManagement.Logic.Views.Class.Menu;
using BookStoreManagement.Models.Models;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace BookStoreManagement.OnConfiguration.OnConfiguration
{
    public class BookStoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBook>().To<Book>();
            Bind<IReader>().To<Reader>();
            Bind<IWriter>().To<Writer>();
            Bind<IEngine>().To<Engine>();
            Bind<ICleaner>().To<Cleaner>();
            Bind<IBookFactory>().ToFactory();
            Bind<IFileReader>().To<FileReader>();
            Bind<IFileWriter>().To<FileWriter>();
            Bind<IBookFileServices>().To<BookFileServices>();
            Bind<IGetKeywordService>().To<GetKeywordService>();
            Bind<IAddBookFormService>().To<AddBookFormService>();
            Bind<IBookDisplayService>().To<BookDisplayService>();
            Bind<IBooksMainViewService>().To<BooksMainViewService>();
            Bind<IBookManipulateService>().To<BookManipulateService>();
            Bind<IBookDisplayController>().To<BookDisplayController>();
            Bind<IGetKeywordViewService>().To<GetKeywordViewService>();
            Bind<IAddBookFormViewService>().To<AddBookFormViewService>();
            Bind<IBookDisplayViewService>().To<BookDisplayViewService>();
            Bind<IBookManipulateController>().To<BookManipulateController>();
            Bind<ICalculateDiscountService>().To<CalculateDiscountService>();
            Bind<IBookManipulateViewService>().To<BookManipulateViewService>();
            Bind<IBookDisplayInputController>().To<BookDisplayInputController>();
            Bind<IBookManipulateInputController>().To<BookManipulateInputController>();
            Bind<IBookStoreManagementController>().To<BookStoreManagementController>();
        }
    }
}
