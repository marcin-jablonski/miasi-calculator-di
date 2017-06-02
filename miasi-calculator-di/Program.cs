using System;
using Ninject;

namespace miasi_calculator_di
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = DIKernelFactory.GetKernel();

            var calc = kernel.Get<Calculator>();

            Console.WriteLine(calc.Compute(3, '+', 2));
            Console.WriteLine(calc.Compute(3, '-', 2));
        }
    }
}
