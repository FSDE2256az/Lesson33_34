using Interface_Segragation.BadCase;
using Interface_Segragation.GoodCase.Abstracts;

namespace Interface_Segragation.GoodCase.Concretes;

public class ReadRepository : IReadRepository
{
    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public Product GetById(int Id)
    {
        throw new NotImplementedException();
    }
}
