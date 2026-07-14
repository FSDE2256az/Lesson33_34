using Interface_Segragation.BadCase;

namespace Interface_Segragation.GoodCase.Abstracts;

public interface IReadRepository
{
    List<Product> GetAll();
    Product GetById(int Id);
}
