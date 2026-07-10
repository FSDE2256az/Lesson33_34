using OpenClosedPrinciple.GoodCase.Abstract;

namespace OpenClosedPrinciple.GoodCase.Concrete;

class HighSalaryCalculator : ISalaryCalculate
{
    public decimal SalaryCalculator(decimal salary)
    {
        return salary * 6;
    }
}
