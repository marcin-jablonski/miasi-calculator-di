namespace miasi_calculator_di.Operations
{
    class AddOperation : IOperation
    {
        public char GetSymbol()
        {
            return '+';
        }

        public double Compute(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
