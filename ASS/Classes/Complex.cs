namespace ASS.Classes;

internal class Complex
{
    public int Real { get; set; }
    public int Img { get; set; }
    public static  Complex operator +(Complex c1 , Complex c2)
    {
        return new Complex()
        {
            Real = (c1?.Real ?? 0 )+ (c2?.Real ?? 0),
            Img = (c1?.Img ?? 0) + (c2?.Img ?? 0)
        };
    }
}
