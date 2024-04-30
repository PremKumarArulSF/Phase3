using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVoume
{
    public abstract class Shape //abstract class
    {
        
      //Field
       protected double _area;
       protected double _volume;
        //Abstract properties
        public abstract double Area { get; set; }
        public abstract double  Volume { get; set; }
        //Non Abstract properties
        public int  Radius { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Page{get;set;}

        //Abstract method

        public abstract double CalculateArea();
        public abstract double CalculateVolume();
        
        





    }
}