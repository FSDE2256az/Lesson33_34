using Interface_Segragation.BadCase;

namespace Interface_Segragation.GoodCase.Abstracts;

public interface IWriteRepository
{
    bool Update(Product product);
    bool Add(Product product);
    bool Delete(int Id);
}
