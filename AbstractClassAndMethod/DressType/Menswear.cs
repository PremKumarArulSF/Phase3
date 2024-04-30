using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DressType
{
    public class Menswear : Dress
    {
        public override  DressType DressType {get;set;}
        public override string DressName{get;set;}
        public override int Price{get;set;}
        public override int TotalPrice{get;set;}
        public override void GetDressInfo()
        {
            System.Console.WriteLine($"The dress Type is {DressType} Dress name is {DressName} Price is {Price}");
        }
        public override void DisplayInfo()
        {
            double discount=(double)Price*30/100;
            double result=Price-discount;
            System.Console.WriteLine("The discount amount of dress is {0}",result);
        }
    }
}