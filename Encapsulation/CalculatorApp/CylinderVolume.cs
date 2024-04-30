using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using MathsLib;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
         private int _height=8;
         public int Height{get{return _height;}set{_height=value;}}
         internal double volume;

         public double CalculateVolume()
         {
            volume=CalculateCircleArea()*_height;
            return Math.Round(volume,2);
         }
    }
}