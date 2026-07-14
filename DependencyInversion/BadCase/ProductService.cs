namespace DependencyInversion.BadCase;

public class ProductService
{
    private readonly ProductRepositoryFromSql _repositoryFromSql;

    public ProductService(ProductRepositoryFromSql repositoryFromSql)
    {
        _repositoryFromSql = repositoryFromSql;
    }

    public List<string> GetProductName()
    {
        return _repositoryFromSql.GetProductNames();
    }

}
