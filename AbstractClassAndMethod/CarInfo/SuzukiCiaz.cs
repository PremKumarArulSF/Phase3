using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public class SuzukiCiaz :Car
    {
        public override void DisplayDetails()
          {
            System.Console.WriteLine("Coming to SuzukiCiaz Car");
          }
         public override void GetEngineType()
         {
               System.Console.WriteLine("The engine type is "+EngineType);
         }
          public override void GetNoOFSeats(){
              System.Console.WriteLine("The Number Of Seat is "+NoOfSeats);
          }
          public override void GetPrice(){
            System.Console.WriteLine("The Price is "+Price);
          }
          public override void GetCarType(){
            System.Console.WriteLine("The Car type is "+CarType);
          }
    }
}