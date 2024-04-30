using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;
namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected int _radius=9;
        public int Radius { get{return _radius;} set{_radius=value;} }
        internal double area;
        
         public double CalculateCircleArea()
         {
            area=_pI*_radius*_radius;
            return  area;
         }
        
        
    }
}