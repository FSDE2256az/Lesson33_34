namespace SingleResponsibility.GoodCase;

public class ProductRepository
{
    private static List<Product> ProductList = new List<Product>();

    static ProductRepository()
    {
        ProductList = new List<Product>()
        {
            new Product(){Id = 1, Name = "Qelem"},
            new Product(){Id = 2, Name = "Defter"},
            new Product(){Id = 3, Name = "Kitab"},
        };
    }

    public void SaveOrUpdate(Product product)
    {
        var hasProduct = ProductList.Any(x => x.Id == product.Id);

        if (!hasProduct)
        {
            ProductList.Add(product);
        }
        else
        {
            var index = ProductList.FindIndex(x => x.Id == product.Id);

            ProductList[index] = product;
        }
    }

    public void DeleteProduct(int id)
    {
        var product = ProductList.FirstOrDefault(x => x.Id == id);

        ProductList.Remove(product!);
    }

  
}
