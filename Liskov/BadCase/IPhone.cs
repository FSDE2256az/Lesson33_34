using Liskov.BadCase.Abstract;

namespace Liskov.BadCase;

class IPhone : BasePhone
{
    public new void Call()
    {
        Console.WriteLine("IPhone called");
    }

    public override void TakePhoto()
    {
        Console.WriteLine("IPhone take photos");
    }
}
