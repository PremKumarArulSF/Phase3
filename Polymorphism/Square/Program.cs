using System;
class Program{
    public static void Main(string[] args)
    {
        
       int num1=3;
       System.Console.WriteLine(Square(num1));
       float num2=3.0f;
       System.Console.WriteLine(Square(num2));
       double num3=4.4;
       System.Console.WriteLine(Square(num3));
       long num4=123455;
       System.Console.WriteLine(Square(num4));


    }
    public static int Square(int a)
    {
        return a*a;
    }
    public static float Square(float a)
    {
        return (float)Math.Round(a*a,2);
    }
    public static double Square(double a)
    {
        return Math.Round(a*a,2);
    }
    public static long Square(long a)
    {
        return a*a;
    }
}
