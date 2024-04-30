using System;
namespace AnimalInfo;
class Program{
    public static void Main(string[] args)
    {
        Dog dog=new Dog();
        dog.Name="Bulldog";
        dog.Habitat="America";
        dog.EatingHabit="Meat";
        Dog dog1=new Dog();
        dog1.Name="Rajapalayam Dog";
        dog1.Habitat="Rajapalayam";
        dog1.EatingHabit="Meat";
        Duck duck=new Duck();
        duck.Name="Mallard";
        duck.Habitat="North America";
        duck.EatingHabit="Seed";
        Duck duck1=new Duck();
        duck1.Name="Indian Runner duck";
        duck1.Habitat="East Indies";
        duck1.EatingHabit="Worms";
        dog.DisplayInfo();
        dog1.DisplayInfo();
        duck.DisplayInfo();
        duck1.DisplayInfo();

    }
}
