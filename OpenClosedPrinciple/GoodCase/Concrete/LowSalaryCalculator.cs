using OpenClosedPrinciple.GoodCase.Abstract;

namespace OpenClosedPrinciple.GoodCase.Concrete;

class LowSalaryCalculator : ISalaryCalculate
{
    public decimal SalaryCalculator(decimal salary)
    {
        return salary * 2;
    }
}
