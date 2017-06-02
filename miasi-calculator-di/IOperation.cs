namespace miasi_calculator_di
{
    interface IOperation
    {
        char GetSymbol();
        double Compute(double firstOperand, double secondOperand);
    }
}
