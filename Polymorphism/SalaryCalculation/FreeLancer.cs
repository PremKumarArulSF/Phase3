using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class FreeLancer : PersonalDetails
    {
//         Property: Role, SalaryAmount, NoOfWorkingDays

// Method : Virtual CalculateSalary method that calculate salary by NoOfWorkingDays*500 
// and virtual display method that display employees details

 public string Role { get; set; }

 public int  SalaryAmount { get; set; }
 public int NoOfWorkingDays { get; set; }

 public FreeLancer(string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays): base( name, fatherName, gender, qualification)
 {
    Role=role;
    NoOfWorkingDays=noOfWorkingDays;

 }
 public virtual void CalculateSalary()
 {
        SalaryAmount=NoOfWorkingDays*500;
 }
 public virtual void Display()
 {
    System.Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nGender: {Gender} \nQualification:{Qualification} \nRole:{Role} \nSalaryAmount: {SalaryAmount}");
 }
 
 
 
 
 
    }
}