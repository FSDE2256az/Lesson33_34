using OpenClosedPrinciple.GoodCase.Abstract;

namespace OpenClosedPrinciple.GoodCase.Concrete;

class ManagerSalaryCalculator : ISalaryCalculate
{
    public decimal SalaryCalculator(decimal salary)
    {
        return salary * 8;
    }
}
