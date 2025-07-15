namespace Demo;
using Demo.Overloading;
class Program
{
    #region Method Overloading

    // public static int SumTwoNumbers(int a, int b)
    // {
    //     return a + b;
    // }
    // public static double SumTwoNumbers(double a, double b)  // method overloading
    // {
    //     return a + b;
    // }
    // public static int SumThreeNumbers(int a, int b, int c)
    // {
    //     return a + b + c;
    // }
    //
    // public static double SumThreeNumbers(double a, double b, double c)
    // {
    //     return a + b + c;
    // }
    //
    // public static int SumNumbers(int a, int b)
    // {
    //     return a + b;
    // }
    //
    // public static double SumNumbers(double a, double b)
    // {
    //     return a + b;
    // }
    //
    // public static int SumNumbers(double a, int b)
    // {
    //     return (int)a + b;
    // }
    //
    // public static int SumNumbers(int a, int b, int c)
    // {
    //     return a + b + c;
    // }
    // public static double SumNumbers(double a, double b, double c)
    // {
    //     return a + b + c;
    // }
    #endregion
    
    static void Main(string[] args)
    {
        #region Demo
        
        #region Method Overloading - Polymorphism
        //int x = 10, y = 20 , z = 30;
        // Console.WriteLine(SumTwoNumbers(x,y));
        // Console.WriteLine(SumThreeNumbers(x, y, z));
        
        
        //double a = 10.5, b = 20.5, c = 30.5;
        // Console.WriteLine(SumTwoNumbers(a,b));
        // Console.WriteLine(SumThreeNumbers(a, b, c));

        // Console.WriteLine(SumNumbers(x, y));
        // Console.WriteLine(SumNumbers(a , x));
        // Console.WriteLine(SumNumbers(x,  y, z));
        // Console.WriteLine(SumNumbers(a ,b , c));
        #endregion
        
        #region Operator Overloading [Binary Operator]

        // int x = 10, y = 20;
        // Console.WriteLine(x+y);
        // Complex c1 = new Complex();
        // // 1] allocate 8 bytes in heap
        // // 2] inti with the default val 
        // // 3] call user defined ctor [if exist]
        // // 4] assign address of instance to the ref in the stack 
        //
        // c1.Real = 4;
        // c1.Img = 5;
        // Complex c2 = new Complex() {Real = 6 , Img = 7};
        // Complex? c3 = default;
        // c3 = c1 + c2;   // op overloading +
        // Console.WriteLine(c3);
        // c3 = c1 - c2;
        // Console.WriteLine(c3);
        // // c3 -= c1;  // valid 
        // // when u debug in op overloading --> u have to put break point on method
        

        #endregion
        
        #region Operator Overloading [Unary Operator]
        
        // prefix - postfix 
        // ++x , x++
        // Complex c1 = new Complex() {Real = 4 , Img = 5};
        // Console.WriteLine(c1);
        // ++c1;
        // Console.WriteLine(c1);
        // c1--;
        // Console.WriteLine(c1);

        #endregion
        
        #region Operator Overloading [Relational Operator]
        
        // Complex c1 = new Complex() {Real = 4 , Img = 5};
        // Complex c2 = new Complex() {Real = 6 , Img = 7};
        // if(c1 > c2) 
        //     Console.WriteLine("c1 is greater than c2");
        // else if(c1 < c2)
        //     Console.WriteLine("c1 is less than c2");
        // else if(c1 == c2)
        //     Console.WriteLine("c1 is equal to c2");
        
        #endregion
        
        #region Operator Overloading [Casting Operator]
        
        // int x = 10;
        // float y = x;  // implicit casting 
        // int z = (int)y;  // explicit casting [unsafe]
        //
        // Complex c1 = new Complex() {Real = 4 , Img = 5};
        // int c = (int)c1;  // use casting op
        // Console.WriteLine(c);
        //
        // string str = (string)c1; // expicit better than implicit
        //
        //
        

        #endregion
        
        #endregion
    }
}