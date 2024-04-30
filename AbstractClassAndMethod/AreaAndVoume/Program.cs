using System;
using AreaAndVoume;
namespace AreaAndVolume;
class Program{
   public static void Main(string[] args)
   {
    Cylinder cylinder=new Cylinder();
    cylinder.Page=2;
    cylinder.Height=10;
    cylinder.Width=13;
    cylinder.Radius=5;
    System.Console.WriteLine(cylinder.CalculateArea());
    System.Console.WriteLine(cylinder.CalculateVolume());
    Cube cube=new Cube();
    cube.Radius=7;
    cube.Height=18;
    cube.Width=15;
    cube.Page=7;
    System.Console.WriteLine(cube.CalculateArea());
    System.Console.WriteLine(cube.CalculateVolume());
   } 
}
