using System;
namespace CarInfo;
class Program{
    public static void Main(string[] args)
    {
       // Properties: Engine type -Petrol,diesel,cng, No.Of.Seats, Price, CarType -hatchback,sedan, suv 
       //get engine type, get no. of seats, get price, get car type, Display  car detail
        MaruthiSwift car1=new MaruthiSwift();
        car1.EngineType=EngineType.Diesel;
        car1.NoOfSeats=5;
        car1.Price=500000;
        car1.CarType=CarType.Sedan;
        car1.DisplayDetails();
        car1.GetNoOFSeats();
        car1.GetEngineType();
        car1.GetPrice();
        car1.GetCarType();

        SuzukiCiaz car2=new SuzukiCiaz();
        car2.EngineType=EngineType.Diesel;
        car2.NoOfSeats=4;
        car2.Price=600000;
        car2.CarType=CarType.Hatchback;
        car2.DisplayDetails();
        car2.GetNoOFSeats();
        car2.GetEngineType();
        car2.GetPrice();
        car2.GetCarType();


    }
}
