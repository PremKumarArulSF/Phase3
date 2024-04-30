using System;
using System.Runtime.InteropServices;
namespace CalculatorApp;
class Program
{
    public static void Main(string[] args)
    {
        CircleArea area=new CircleArea();
        CylinderVolume volume=new CylinderVolume();
        Console.WriteLine(area.CalculateCircleArea());
        System.Console.WriteLine(volume.CalculateVolume());
    }
}
