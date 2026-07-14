using DependencyInversion.GoodCase.Abstract;

namespace DependencyInversion.GoodCase;

public class ProductService
{
    private readonly IRepository _repository;

    public ProductService(IRepository repository)
    {
        _repository = repository;
    }

    public List<string> GetAllProductName()
    {
        return _repository.GetAll();
    }
}
