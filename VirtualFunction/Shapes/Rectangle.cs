using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Dimension
    {
   public int Length =10;
   public int Height=20;

    public override double Calculate()
    {
        return Length*Height;
    }
    public override double DisplayArea()
    {
            Area=Calculate();
            return Area;
    }
    }
}