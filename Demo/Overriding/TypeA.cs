namespace Demo.Overriding;

internal class TypeA
{
    #region Properties

    public int A { get; set;}

    #endregion

    #region Ctor

    public TypeA(){}
    public TypeA(int a)
    {
        A = a;
    }
    #endregion

    #region Methods
    
    // virtual and non private in first appearance
    public virtual void Fun01()
    {
        Console.WriteLine($"I am base - [TypeA]");
    }

    public virtual void Fun02()
    {
        Console.WriteLine($"Type A --> A : {A}");
    }

    public override string ToString()
    {
        return $" A : {A}";
    }

    #endregion
    
}