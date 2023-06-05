using BookStoreManagement.Logic.Core;
using BookStoreManagement.OnConfiguration.OnConfiguration;
using Ninject;



IKernel kernel = new StandardKernel(new BookStoreModule());
IEngine engine = kernel.Get<IEngine>();

engine.Run();

//try
//{
    
//}
//catch(Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}