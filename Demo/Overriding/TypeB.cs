namespace Demo.Overriding;

internal class TypeB : TypeA
{
    public int B { get; set; }

    public TypeB(int a, int b)
    {
        A = a;
        B = b;
    }
    public override string ToString()
    {
        return base.ToString() + $" , B : {B}";
    }

    public override void Fun01()
    {
        Console.WriteLine($"I am derived - [TypeB]");
    }
    public override void Fun02()
    {
        Console.WriteLine($"Type B --> B : {B}");
    }
}