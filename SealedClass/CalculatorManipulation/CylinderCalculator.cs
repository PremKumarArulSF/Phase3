using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorManipulation
{
    public class CylinderCalculator : Calculator
    {
        public double Result { get; set; }
        
        
        public override void Area()
        {
            int r=3;
            Result=3.14*r*r;
        }
    }
}