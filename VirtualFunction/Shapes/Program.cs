using System;
using System.Drawing;
using Shapes;
namespace Shapes;
class Program{
    public static void Main(string[] args)
    {
         Rectangle rectangle=new Rectangle();  
        System.Console.WriteLine(rectangle.DisplayArea());
        Sphere sphere=new Sphere();
        System.Console.WriteLine(sphere.DisplayArea());
    }
}
