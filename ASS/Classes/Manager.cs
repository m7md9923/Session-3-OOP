namespace ASS.Classes;

internal class Manager : Employee
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Manager is working");
    }
}
