using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Dimension
    {


     //Property
     public int Value1 =10;
     public int value2 =20;
     public double Area { get; set; }

     //Method
     public virtual double Calculate()
     {
        return value2*value2;
     }
     public virtual double DisplayArea()
     {
        Area=Calculate();
        return Area;
     }
    }
}