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
            Bind<IReader>().To<Reader>().InSingletonScope();
            Bind<IWriter>().To<Writer>().InSingletonScope();
            Bind<IEngine>().To<Engine>().InSingletonScope();
            Bind<ICleaner>().To<Cleaner>().InSingletonScope();
            Bind<IBookFactory>().ToFactory().InSingletonScope();
            Bind<IFileReader>().To<FileReader>().InSingletonScope();
            Bind<IFileWriter>().To<FileWriter>().InSingletonScope();
            Bind<IBookFileService>().To<BookFileServices>().InSingletonScope();
            Bind<IGetKeywordService>().To<GetKeywordService>().InSingletonScope();
            Bind<IAddBookFormService>().To<AddBookFormService>().InSingletonScope();
            Bind<IBookDisplayService>().To<BookDisplayService>().InSingletonScope();
            Bind<IBooksMainView>().To<BooksMainView>().InSingletonScope();
            Bind<IBookManipulateService>().To<BookManipulateService>().InSingletonScope();
            Bind<IBookDisplayController>().To<BookDisplayController>().InSingletonScope();
            Bind<IGetKeywordView>().To<GetKeywordView>().InSingletonScope();
            Bind<IAddBookFormView>().To<AddBookFormView>().InSingletonScope();
            Bind<IBookDisplayView>().To<BookDisplayView>().InSingletonScope();
            Bind<IBookManipulateController>().To<BookManipulateController>().InSingletonScope();
            Bind<ICalculateDiscountService>().To<CalculateDiscountService>().InSingletonScope();
            Bind<IBookManipulateView>().To<BookManipulateView>().InSingletonScope();
            Bind<IBookDisplayInputController>().To<BookDisplayInputController>().InSingletonScope();
            Bind<IBookManipulateInputController>().To<BookManipulateInputController>().InSingletonScope();
            Bind<IBookStoreManagementController>().To<BookStoreManagementController>().InSingletonScope();
        }
    }
}
