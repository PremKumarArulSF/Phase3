using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkSheet
{
    public interface ICalculate
    {
         int ProjectMark{get;set;}
         double CalculateMark(int[] a);
    }
}