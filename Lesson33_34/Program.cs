using SingleResponsibility.BadCase;

namespace SingleResponsibility;

public class Program
{
    static void Main(string[] args)
    {
        var products = new Product();

        products.DeleteProduct(1);

        products.PrintProductList();
    }
}
