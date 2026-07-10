namespace SingleResponsibility.GoodCase;

static class ProductPrinter
{
    public static void PrintProductList(List<Product> ProductList)
    {
        ProductList.ForEach(x => Console.WriteLine(x.Id));
    }
}
