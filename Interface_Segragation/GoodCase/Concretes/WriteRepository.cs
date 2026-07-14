using Interface_Segragation.BadCase;
using Interface_Segragation.GoodCase.Abstracts;

namespace Interface_Segragation.GoodCase;

public class WriteRepository : IWriteRepository
{
    public bool Add(Product product)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product product)
    {
        throw new NotImplementedException();
    }
}
