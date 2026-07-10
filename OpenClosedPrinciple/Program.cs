using OpenClosedPrinciple.GoodCase;
using OpenClosedPrinciple.GoodCase.Concrete;

namespace OpenClosedPrinciple;

public class Program
{
    static void Main(string[] args)
    {
        SalaryCalculator.Salary(150, new LowSalaryCalculator());
        SalaryCalculator.Salary(150, new MiddleSalaryCalculate());
        SalaryCalculator.Salary(150, new HighSalaryCalculator());
        SalaryCalculator.Salary(150, new ManagerSalaryCalculator());


    }
}
