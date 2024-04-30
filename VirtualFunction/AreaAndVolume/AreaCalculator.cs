using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreaAndVolume
{
    public class AreaCalculator
    {
    //Field
    
    //Property
    public int Radius{get;set;}
    public AreaCalculator(int radius)
    {
        Radius=radius;
    }
    //Method
    public virtual  double Calculate ()
    {
        return Math.PI*Radius*Radius;
    }
    public virtual double Display()
    {
            return Math.Round(Calculate(),2);
    }
    
    }
}