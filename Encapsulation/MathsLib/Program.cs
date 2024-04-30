using System;
using System.Net.NetworkInformation;
namespace MathsLib;
class Program{
    public static void Main(string[] args)
    {
        //protected internal PI=3.14;
        Maths math=new Maths();
        System.Console.WriteLine("Enter the mass weigth: ");
        double Mass=int.Parse(Console.ReadLine());
        System.Console.WriteLine(math.CalulateWeight(Mass));

    }
}
