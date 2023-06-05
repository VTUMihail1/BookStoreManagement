using BookStoreManagement.Logic.Core;
using BookStoreManagement.OnConfiguration.OnConfiguration;
using Ninject;



try
{
    IKernel kernel = new StandardKernel(new BookStoreModule());
    IEngine engine = kernel.Get<IEngine>();

    engine.Run();
}
catch(Exception exception)
{
    Console.WriteLine(exception.Message);
}