using Liskov.GoodCase.Abstract;

namespace Liskov.GoodCase;

class IPhone : BaseClass, BaseImplementation
{
    public new void Call()
    {
        Console.WriteLine("IPhone called");
    }

    public void TakePhoto()
    {
        Console.WriteLine("IPhone take photo");
    }
}
