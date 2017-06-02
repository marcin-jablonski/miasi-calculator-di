using System.Collections.Generic;
using System.Linq;
using Ninject;

namespace miasi_calculator_di
{
    class Calculator
    {
        [Inject]
        public IEnumerable<IOperation> Operations { private get; set; }

        public double Compute(double firstOperand, char symbol, double secondOperand)
        {
            return Operations.First(x => x.GetSymbol() == symbol).Compute(firstOperand, secondOperand);
        }
    }
}
