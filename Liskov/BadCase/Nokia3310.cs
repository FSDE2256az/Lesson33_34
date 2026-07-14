using Liskov.BadCase.Abstract;

namespace Liskov.BadCase;

public class Nokia3310 : BasePhone
{
    public new void Call()
    {
        Console.WriteLine("Nokia3310 called");
    }

    public override void TakePhoto()
    {
        // Console.WriteLine("Nokia3310 take photos");
        throw new NotImplementedException();
    }
}
