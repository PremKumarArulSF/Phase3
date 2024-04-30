using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public class Dog : IAnimal
    {
        private string _name;
        private string _habitat;
        private string _eatingHabit;
        public string  Name { get{return _name;} set{ _name=value;} }
        public string  Habitat { get{return _habitat;} set{_habitat=value;} }
        public string  EatingHabit { get{return _eatingHabit;} set{_eatingHabit=value;} }

        public void DisplayName()
        {
             System.Console.WriteLine(_name);
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name : {_name} | Habitat: {_habitat} | EatingHabit: {_eatingHabit}");
        }

    }
}