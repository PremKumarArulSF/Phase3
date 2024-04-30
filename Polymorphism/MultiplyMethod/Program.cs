using System;
using System.Reflection.Metadata.Ecma335;
namespace MultiplyMethod;
class Program
{
    public static void Main(string[] args)
    {

        System.Console.WriteLine(MultiplyMethod(2));
        System.Console.WriteLine(MultiplyMethod(2.1, 3.2));
        System.Console.WriteLine(MultiplyMethod(2, 5, 6));
        System.Console.WriteLine(MultiplyMethod(1, 2.0));
        System.Console.WriteLine(MultiplyMethod(1, 1.0, 'c'));
    }
    public static int MultiplyMethod(int a)
    {
        return a * a;
    }
    public static double MultiplyMethod(double a, double b)
    {
        return Math.Round(a * b,2);
    }
    public static int MultiplyMethod(int a, int b, int c)
    {
        return a * b * c;
    }
    public static double MultiplyMethod(int a, double b)
    {
        return a * b;
    }
    public static double MultiplyMethod(int a, double b, char c)
    {
        return Math.Round(a * b * c,2);
    }

}


