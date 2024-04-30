using System;
namespace DressType;
class Program{
    public static void Main(string[] args)
    {
        LadiesWear ladies=new LadiesWear();
        ladies.DressType=DressType.Ladieswear;
        ladies.DressName="Jean";
        ladies.Price=1000;
        ladies.GetDressInfo();
        ladies.DisplayInfo();
        Menswear men=new Menswear();
        men.DressType=DressType.Menswear;
        men.DressName="Shirt";
        men.Price=1000;
        men.GetDressInfo();
        men.DisplayInfo();

       
    }
}