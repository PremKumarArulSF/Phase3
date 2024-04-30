using System;
namespace AreaAndVolume;
class Program{
    public static void Main(string[] args)
    {
        AreaCalculator area=new AreaCalculator(5);
        System.Console.WriteLine(area.Display());
        VolumeCalculator volume=new VolumeCalculator(area.Radius,4);
        
        System.Console.WriteLine(volume.Display());
    }
}
