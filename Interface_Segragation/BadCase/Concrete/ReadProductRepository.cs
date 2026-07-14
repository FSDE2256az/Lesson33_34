using Interface_Segragation.BadCase.Abstract;

namespace Interface_Segragation.BadCase.Concrete;

public class ReadProductRepository : IProductRepository
{
    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product GetById(int Id)
    {
        throw new NotImplementedException();
    }
    public bool Add(Product product)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product product)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int Id)
    {
        throw new NotImplementedException();
    }
}
