namespace OpenClosedPrinciple.BadCase;

public enum SalaryEnum
{
    Low,
    Middle,
    High,
    Manager

}


public static class SalaryCalculator
{
    public static double Salary(double salary, SalaryEnum salaryEnum)
    {
        double salaryResult = default!;
        switch (salaryEnum)
        {
            case SalaryEnum.Low:
                salaryResult = salary * 2;
                break;
            case SalaryEnum.Middle:
                salaryResult = salary * 4;
                break;
            case SalaryEnum.High:
                salaryResult = salary * 6;
                break;
            case SalaryEnum.Manager: // Mentiqi deyisiklik etdim
                salaryResult = salary * 8;
                break;
            default:
                salaryResult = salary * 1;
                break;
        }

        return salaryResult;
    }


}