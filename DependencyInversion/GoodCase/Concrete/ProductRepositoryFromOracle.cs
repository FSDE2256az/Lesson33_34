using DependencyInversion.GoodCase.Abstract;

namespace DependencyInversion.GoodCase.Concrete;

public class ProductRepositoryFromOracle : IRepository
{ 
    public List<string> GetAll()
    {
        return new List<string>() { "Cappy", "Fuse Tea", "Gulustan", "Mor mor" };
    }
}
