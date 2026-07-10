using OpenClosedPrinciple.GoodCase.Abstract;

namespace OpenClosedPrinciple.GoodCase;

public static class SalaryCalculator
{
    public static decimal Salary(decimal salary, ISalaryCalculate salaryCalculate)
    {
        return salaryCalculate.SalaryCalculator(salary);
    }
}
