using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double _pI=3.14;
        internal double _g=9.8;
        // protected internal double PI{get{return _pI;}}
        // internal double g{get{return _g;}}

        public double CalulateWeight(double mass)
        {
            return Math.Round(mass*_g);
        }
        

    }
}