using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVoume
{
    public class Cylinder : Shape
    {
        public override double  Area {get{ return _area;} set {_area =value;}}
        public override double Volume {get{ return _volume;} set {_volume =value;}}
       
         //Override methods
        public override double CalculateArea()
        {
             //2 π r(r+h) ,
           _area= (double)2*Math.PI*Radius*(Radius+Height);
           return Math.Round(_area,2);

        }
        public override double CalculateVolume()
        {
            _volume= (double)Math.PI*Math.Pow(Radius,2)*Height;
           return Math.Round(_volume,2);
        }


    }
}