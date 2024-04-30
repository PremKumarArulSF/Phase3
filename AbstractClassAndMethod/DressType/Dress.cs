using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DressType
{
    public enum DressType{Select,Ladieswear,Menswear,Kidswear}
    public abstract class Dress
    {


        //Abstract Properties
        public abstract  DressType DressType { get; set; }
        public abstract string  DressName { get; set; }
        public abstract int Price { get; set; }
        public abstract int TotalPrice { get; set; }
  //Abstract Method
   public abstract void GetDressInfo();
   public abstract void DisplayInfo();
    }
}