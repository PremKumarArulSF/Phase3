using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVoume
{
    public class Cube : Shape
    {
         public override double  Area {get{ return _area;} set {_area =value;}}
        public override double Volume {get{ return _volume;} set {_volume =value;}}

        //Override methods
        public override double CalculateArea() 
        {
             //2 π r(r+h) ,
           _area= (double) 6*Math.Pow(Page,2);
           return Math.Round(_area,2);

        }
        public override double CalculateVolume()
        {
            _volume= (double)Math.Pow(Page,3);
           return Math.Round(_volume,2);
        }

    }
}