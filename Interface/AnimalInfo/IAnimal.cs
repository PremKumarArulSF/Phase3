using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalInfo
{
    public interface IAnimal
    {
       
       //Properties
       string Name{get;set;}
       string Habitat{get;set;}
       string EatingHabit{get;set;}

       //Method declartion
       void DisplayName();
    }
}