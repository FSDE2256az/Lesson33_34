namespace DependencyInversion.BadCase;

public class ProductRepositoryFromSql
{
    public List<string> GetProductNames()
    {
        return new List<string>() { "Cola", "Fanta", "Pepsi", "Sprite" };
    }


}


//public class ProductRepositoryFromOracle
//{
//    public List<string> GetProductNames()
//    {
//        return new List<string>() { "Cola", "Fanta", "Pepsi", "Sprite" };
//    }
//}
