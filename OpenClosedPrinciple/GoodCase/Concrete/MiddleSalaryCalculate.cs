using OpenClosedPrinciple.GoodCase.Abstract;

namespace OpenClosedPrinciple.GoodCase.Concrete;

class MiddleSalaryCalculate : ISalaryCalculate
{
    public decimal SalaryCalculator(decimal salary)
    {
        return salary * 4;
    }
}
