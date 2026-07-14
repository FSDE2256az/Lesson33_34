using DependencyInversion.GoodCase;
using DependencyInversion.GoodCase.Abstract;
using DependencyInversion.GoodCase.Concrete;

namespace DependencyInversion;

public class Program
{
    static void Main(string[] args)
    {
        // // Bad Case
        // var productFromSql = new DependencyInversion.BadCase.ProductRepositoryFromSql();
        // var productFromOracle = new DependencyInversion.BadCase.ProductRepositoryFromOracle();
        //
        // var productBadService = new DependencyInversion.BadCase.ProductService(productFromOracle);


        // // Good Case
        List<IRepository> repositories = new List<IRepository>()
        {
            new ProductRepositoryFromSql(),
            new ProductRepositoryFromOracle(),
        };

        var productService = new ProductService(repositories[1]);

        productService.GetAllProductName().ForEach(x => Console.WriteLine(x));

    }
}
