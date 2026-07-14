using DependencyInversion.GoodCase.Abstract;


namespace DependencyInversion.GoodCase.Concrete;

class ProductRepositoryFromSql : IRepository
{
    public List<string> GetAll()
    {
        return new List<string>() { "Cola", "Fanta", "Pepsi", "Sprite" };
    }
}
