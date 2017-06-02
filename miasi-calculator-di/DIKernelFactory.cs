using Ninject;
using Ninject.Extensions.Conventions;

namespace miasi_calculator_di
{
    public static class DIKernelFactory
    {
        public static IKernel GetKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind(scanner => scanner.FromThisAssembly()
                  .IncludingNonePublicTypes()
                  .SelectAllClasses()
                  .InNamespaces("miasi_calculator_di")
                  .BindAllInterfaces());
            return kernel;
        }
    }
}