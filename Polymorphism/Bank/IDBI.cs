using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank
{
    public class IDBI :BankClass
    {
        public override double GetIntersetInfo()
        {
            return Math.Round(7.5/100,2);
        }
    }
}