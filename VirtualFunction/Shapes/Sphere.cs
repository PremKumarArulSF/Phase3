using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere :Dimension
    { 

   public int Radius=5;
   public override double Calculate()
   {
      return 4*Math.PI*Radius*Radius;
   }
    public override double DisplayArea()
    {
            Area=Calculate();
            return Math.Round(Area,2);
    }
    }
}