
using System;
namespace PersonalData;
class Program{
    public static void Main(string[] args)
    {
        RegisterPerson person1=new RegisterPerson("Prem","Male",new DateTime(2002,05,22),"9087654321",MaritalDetails.Single,new DateTime(2023,11,03));
        RegisterPerson person2=new RegisterPerson("Karun","Male",new DateTime(2001,03,21),"90876341321",MaritalDetails.Single,new DateTime(2023,04,01));
        person1.ShowInFo();
        person2.ShowInFo();
    }
}