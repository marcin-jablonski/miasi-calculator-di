namespace miasi_calculator_di.Operations
{
    class SubtractOperation : IOperation
    {
        public char GetSymbol()
        {
            return '-';
        }

        public double Compute(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
