using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolume
{
    public class VolumeCalculator: AreaCalculator
    {
        public int Height{get;set;}
        public VolumeCalculator(int radius,int height):base(radius)
        {
            Height=height;
        }
        public override double Calculate ()
        {
            return Math.PI*Height*Radius*Radius;
        }
        public override double Display()
        {
            return Math.Round(Calculate(),2);
        }
    }
}