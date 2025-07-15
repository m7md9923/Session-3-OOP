namespace Demo.Overloading;

public class Complex
{
    // 4+5i
    public int Real { get; set; }
    public int Img { get; set; }

    public override string ToString()
    {
        return $"{Real} + {Img}i";
    }
    #region Binary Operators Overloading

    // public static Complex operator +(Complex c1, Complex c2)
    // {
    //     // Complex res = new Complex()
    //     // {
    //     //     Real = c1.Real + c2.Real,
    //     //     Img = c1.Img + c2.Img
    //     // };
    //     // return res;
    //     
    //     // +/- will be evaluated before ??
    //     return new Complex()  // address of instace in the stack 
    //     {
    //         Real = (c1?.Real ?? 0) + (c2?.Real ?? 0),
    //         Img = (c1?.Img ?? 0) + (c2?.Img ?? 0)
    //     };
    // }
    //
    // public static Complex operator - (Complex c1, Complex c2)
    // {
    //     return new Complex()
    //     {
    //         Real = (c1?.Real ?? 0) - (c2?.Real ?? 0),
    //         Img = (c1?.Img ?? 0) - (c2?.Img ?? 0)
    //     };
    // }
    
    #endregion
    
    #region Unary Operators Overloading

    // public static Complex operator ++(Complex c1)
    // {
    //     // Complex res = new Complex()
    //     // {
    //     //     Real = c1.Real + 1,
    //     //     Img = c1.Img // if u do not write this -- > new will put imaginary val = 0 
    //     // };
    //     // return res;
    //     return new Complex()
    //     {
    //         Real = (c1?.Real ?? 0) + 1,
    //         Img = (c1?.Img ?? 0)
    //     };
    // }
    //
    // public static Complex operator --(Complex c1)
    // {
    //     return new Complex()
    //     {
    //         Real = (c1?.Real ?? 0) - 1,
    //         Img = (c1?.Img ?? 0)
    //     };
    // }
    
    #endregion

    #region Relational Operators Overloading

    // public static bool operator >(Complex c1, Complex c2)
    // {
    //     if(c1.Real > c2.Real) return true;
    //     if(c1.Real == c2.Real && c1.Img > c2.Img) return true;
    //     return false;
    // }
    //
    // public static bool operator <(Complex c1, Complex c2)
    // {
    //     if(c1.Real < c2.Real) return true;
    //     if(c1.Real == c2.Real && c1.Img < c2.Img) return true;
    //     return false;
    // }
    //
    // public static bool operator ==(Complex c1, Complex c2)
    // {
    //     return c1.Real == c2.Real && c1.Img == c2.Img;
    // }
    //
    // public static bool operator !=(Complex c1, Complex c2)
    // {
    //     return !(c1 == c2);
    // }
    #endregion

    #region Casting Operator Overloading

    // public static explicit operator int(Complex c1)
    // {
    //     return c1.Real;
    // }
    //
    // public static implicit operator string(Complex c1)
    // {
    //     return c1.ToString();
    // }
    
    #endregion
    
    #region  
    
    #endregion
}