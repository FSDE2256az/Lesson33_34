using DependencyInversion.GoodCase;
using DependencyInversion.GoodCase.Abstract;
using DependencyInversion.GoodCase.Concrete;

namespace DependencyInversion;

public class Program
{
    static void Main(string[] args)
    {
        List<IRepository> repositories = new List<IRepository>()
        {
            new ProductRepositoryFromSql(),
            new ProductRepositoryFromOracle(),
        };

        var productService = new ProductService(repositories[1]);

        productService.GetAllProductName().ForEach(x=> Console.WriteLine(x));

     }
}
