namespace Interface_Segragation.BadCase.Abstract;

public interface IProductRepository
{
    List<Product> GetAll();
    Product GetById(int Id);
    bool Update(Product product);
    bool Add(Product product);
    bool Delete(int Id);

}
