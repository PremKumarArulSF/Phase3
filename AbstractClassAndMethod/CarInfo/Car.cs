using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo
{
    public enum EngineType{Select,Petrol,Diesel,Cng}
    public enum CarType{Select,Hatchback,Sedan,Suv}
    public abstract class Car
    {
//         Field: No. of wheels=4, No.Of.Doors = 4,

// Properties: Engine type -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback,sedan, suv

// Methods : ShowWheels, show doors

// Abstract methods: get engine type, get no. of seats, get price, get car type, Display  car detail


         //Fields
          
          public int NoOfWheels=4;
          public int NofDoors=4;
          //Properties
          public EngineType EngineType { get; set; }
          public int NoOfSeats { get; set; }
          public int  Price { get; set; }
          public CarType CarType { get; set; }
          //Methods
          public void ShowWheels()
          {
            System.Console.WriteLine("The Number of wheels is {0}",NoOfWheels);
            System.Console.WriteLine("The number of Doors is {0}",NofDoors);
          }
          //Abstract Method
          public abstract void GetEngineType();
          public abstract void GetNoOFSeats();
          public abstract void GetPrice();
          public abstract void GetCarType();
          public abstract void DisplayDetails();
    }
}