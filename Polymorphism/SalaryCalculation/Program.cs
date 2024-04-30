using System;
using SalaryCalculation;
class Program{
    public static void Main(string[] args)
    {
        FreeLancer freeLancer=new FreeLancer("Prem","Arul","male","BE","Software engineer",12);
       freeLancer.CalculateSalary();
       freeLancer.Display();

       Syncfusion employee=new Syncfusion(freeLancer.Name,freeLancer.FatherName,freeLancer.Gender,freeLancer.Qualification,freeLancer.Role,30,"chennai");
       employee.CalculateSalary();
       employee.Display(); 
    }
}
