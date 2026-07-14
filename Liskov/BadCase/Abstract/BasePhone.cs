namespace Liskov.BadCase.Abstract;

public abstract class BasePhone
{
    public void Call()
    {
        Console.WriteLine("BasePhone Called");
    }

    public abstract void TakePhoto();
}
