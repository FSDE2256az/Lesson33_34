using Liskov.GoodCase.Abstract;

namespace Liskov.GoodCase;

class Nokia3310 : BaseClass
{
    public new void Call()
    {
        Console.WriteLine("Nokia3310 called");
    }
}
